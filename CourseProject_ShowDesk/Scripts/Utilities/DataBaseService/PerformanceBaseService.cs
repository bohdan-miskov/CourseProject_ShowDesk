using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService.DataBaseServiceInterface;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService
{
    public class PerformanceBaseService : IPerformanceBaseService
    {
        private readonly IMongoCollection<Performance> upcomingCollection;
        private readonly IMongoCollection<Performance> pastCollection;
        private readonly MongoClient client;

        public PerformanceBaseService()
        {
            try
            {
                client = new MongoClient(AppConstants.ConnectionString);
                var db = client.GetDatabase(AppConstants.GeneralCollectionName);
                var test = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Result;

                upcomingCollection = db.GetCollection<Performance>(AppConstants.PerformancesCollectionName);
                pastCollection = db.GetCollection<Performance>(AppConstants.PastPerformancesCollectionName);
            }
            catch
            {
                throw new DatabaseConnectionException("Could not connect to the database.");
            }
        }

        public List<Performance> GetAllUpcomingPerformances(bool sortByDate = true)
        {
            List<Performance> performances = upcomingCollection.Find(performance => true).ToList();

            foreach (var performance in performances)
            {
                performance.InitializeService(new PerformanceBaseService());
            }

            if (sortByDate)
            {
                performances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));
            }

            return performances;
        }

        public List<Performance> GetAllPastPerformances(bool sortByDate = true)
        {
            List<Performance> performances = pastCollection.Find(performance => true).ToList();

            if (sortByDate)
            {
                performances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));
            }

            return performances;
        }

        public List<Performance> GetPastPerformances(DateTime startDate, DateTime endDate, bool sortByDate = true)
        {
            List<Performance> allPerformances = pastCollection.Find(performance => true).ToList();
            List<Performance> filterPerformances = allPerformances.Where(performance => (DateTime.Compare(performance.PerformanceDateTime, startDate) >= 0) &&
                DateTime.Compare(performance.PerformanceDateTime, endDate) <= 0).ToList();

            if (sortByDate)
            {
                filterPerformances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));
            }


            return allPerformances;
        }
        public Performance GetOldestPerformance()
        {
            List<Performance> allPerformances = pastCollection.Find(performance => true).ToList();

            allPerformances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));

            return allPerformances[0];
        }
        public void MovePastPerformances()
        {
            var now = DateTime.Now;
            var pastFilter = Builders<Performance>.Filter.Lt(p => p.PerformanceDateTime, now);
            var pastPerformances = upcomingCollection.Find(pastFilter).ToList();

            if (pastPerformances.Any())
            {
                pastCollection.InsertMany(pastPerformances);

                var idsToDelete = pastPerformances.Select(p => p.Id).ToList();
                var deleteFilter = Builders<Performance>.Filter.In(p => p.Id, idsToDelete);
                upcomingCollection.DeleteMany(deleteFilter);
            }
        }

        public void AddPerformance(Performance performance)
        {
            upcomingCollection.InsertOne(performance);
        }

        public void RemovePerformance(Guid id)
        {
            var filter = Builders<Performance>.Filter.Eq("Id", id);
            upcomingCollection.DeleteOne(filter);
        }

        public void AddTicket(Guid performanceId, StandardTicket ticket)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Push(p => p.Tickets, ticket);
            upcomingCollection.UpdateOne(filter, update);
        }

        public void RemoveTicket(Guid performanceId, Guid ticketId)
        {
            var filter = Builders<Performance>.Filter.Eq(s => s.Id, performanceId);
            var update = Builders<Performance>.Update.PullFilter(s => s.Tickets, z => z.Id == ticketId);
            upcomingCollection.UpdateOne(filter, update);
        }

        public void UpdatePerformance(Performance updatedPerformance)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, updatedPerformance.Id);
            upcomingCollection.ReplaceOne(filter, updatedPerformance);
        }

        public void UpdateTicket(Guid performanceId, StandardTicket updatedTicket)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);

            // Видалення квитка за його унікальним Id або Index
            var pull = Builders<Performance>.Update.PullFilter(
                p => p.Tickets,
                t => t.Id == updatedTicket.Id
            );

            // Додати новий квиток (оновлений)
            var push = Builders<Performance>.Update.Push(p => p.Tickets, updatedTicket);

            // ⚠ Дві окремі операції — потенційно не атомарно. Рішення: ТРАНЗАКЦІЯ
            using (var session = client.StartSession())
            {
                session.StartTransaction();

                upcomingCollection.UpdateOne(session, filter, pull);
                upcomingCollection.UpdateOne(session, filter, push);

                session.CommitTransaction();
            }
        }
        public void AddPosition(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Push(p => p.AvailablePositions, position);

            upcomingCollection.UpdateOne(filter, update);
        }
        public void RemovePosition(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Pull(p => p.AvailablePositions, position);

            upcomingCollection.UpdateOne(filter, update);
        }
        public bool IsPositionAvailable(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.And(
                Builders<Performance>.Filter.Eq(p => p.Id, performanceId),
                Builders<Performance>.Filter.AnyEq(p => p.AvailablePositions, position)
            );

            return upcomingCollection.Find(filter).Any();
        }
        public Performance GetUpdatedPerformance(Performance performance)
        {
            var filter = Builders<Performance>.Filter.Eq("Id", performance.Id);
            Performance updatedPerformance = upcomingCollection.Find(filter).FirstOrDefault();
            updatedPerformance?.InitializeService(new PerformanceBaseService());

            return updatedPerformance;
        }
    }
}
