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
using System.Threading.Tasks;

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

        public async Task<List<Performance>> GetAllUpcomingPerformancesAsync(bool sortByDate = true)
        {
            var performances = await upcomingCollection.Find(_ => true).ToListAsync();

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

        public async Task<List<Performance>> GetAllPastPerformancesAsync(bool sortByDate = true)
        {
            var performances = await pastCollection.Find(_ => true).ToListAsync();

            if (sortByDate)
            {
                performances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));
            }

            return performances;
        }

        public async Task<List<Performance>> GetPastPerformancesAsync(DateTime startDate, DateTime endDate, bool sortByDate = true)
        {
            var allPerformances = await pastCollection.Find(_ => true).ToListAsync();

            List<Performance> filterPerformances = allPerformances.Where(performance => (DateTime.Compare(performance.PerformanceDateTime, startDate) >= 0) &&
                DateTime.Compare(performance.PerformanceDateTime, endDate) <= 0).ToList();

            if (sortByDate)
            {
                filterPerformances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));
            }

            return filterPerformances;
        }
        public async Task<Performance> GetOldestPerformanceAsync()
        {
            var allPerformances = await pastCollection.Find(_ => true).ToListAsync();

            allPerformances.Sort((p1, p2) => p1.PerformanceDateTime.CompareTo(p2.PerformanceDateTime));

            return allPerformances.Count>0?allPerformances[0]:null;
        }
        public async Task MovePastPerformancesAsync()
        {
            var now = DateTime.Now;
            var pastFilter = Builders<Performance>.Filter.Lt(p => p.PerformanceDateTime, now);
            var pastPerformances = await upcomingCollection.Find(pastFilter).ToListAsync();

            if (pastPerformances.Any())
            {
                await pastCollection.InsertManyAsync(pastPerformances);

                var idsToDelete = pastPerformances.Select(p => p.Id).ToList();
                var deleteFilter = Builders<Performance>.Filter.In(p => p.Id, idsToDelete);
                await upcomingCollection.DeleteManyAsync(deleteFilter);
            }
        }

        public async Task AddPerformanceAsync(Performance performance)
        {
            await upcomingCollection.InsertOneAsync(performance);
        }

        public async Task RemovePerformanceAsync(Guid id)
        {
            var filter = Builders<Performance>.Filter.Eq("Id", id);
            await upcomingCollection.DeleteOneAsync(filter);
        }

        public async Task AddTicketAsync(Guid performanceId, StandardTicket ticket)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Push(p => p.Tickets, ticket);
            await upcomingCollection.UpdateOneAsync(filter, update);
        }

        public async Task RemoveTicketAsync(Guid performanceId, Guid ticketId)
        {
            var filter = Builders<Performance>.Filter.Eq(s => s.Id, performanceId);
            var update = Builders<Performance>.Update.PullFilter(s => s.Tickets, z => z.Id == ticketId);
            await upcomingCollection.UpdateOneAsync(filter, update);
        }

        public async Task UpdatePerformanceAsync(Performance updatedPerformance)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, updatedPerformance.Id);
            await upcomingCollection.ReplaceOneAsync(filter, updatedPerformance);
        }

        public async Task UpdateTicketAsync(Guid performanceId, StandardTicket updatedTicket)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);

            var pull = Builders<Performance>.Update.PullFilter(
                p => p.Tickets,
                t => t.Id == updatedTicket.Id
            );

            var push = Builders<Performance>.Update.Push(p => p.Tickets, updatedTicket);

            using (var session = await client.StartSessionAsync())
            {
                session.StartTransaction();

                await upcomingCollection.UpdateOneAsync(session, filter, pull);
                await upcomingCollection.UpdateOneAsync(session, filter, push);

                await session.CommitTransactionAsync();
            }
        }
        public async Task AddPositionAsync(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Push(p => p.AvailablePositions, position);

            await upcomingCollection.UpdateOneAsync(filter, update);
        }
        public async Task RemovePositionAsync(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.Eq(p => p.Id, performanceId);
            var update = Builders<Performance>.Update.Pull(p => p.AvailablePositions, position);

            await upcomingCollection.UpdateOneAsync(filter, update);
        }
        public async Task<bool> IsPositionAvailableAsync(Guid performanceId, int position)
        {
            var filter = Builders<Performance>.Filter.And(
                Builders<Performance>.Filter.Eq(p => p.Id, performanceId),
                Builders<Performance>.Filter.AnyEq(p => p.AvailablePositions, position)
            );

            return await upcomingCollection.Find(filter).AnyAsync();
        }
        public async Task<Performance> GetUpdatedPerformanceAsync(Performance performance)
        {
            var filter = Builders<Performance>.Filter.Eq("Id", performance.Id);
            var updatedPerformance = await upcomingCollection.Find(filter).FirstOrDefaultAsync();
            updatedPerformance?.InitializeService(new PerformanceBaseService());

            return updatedPerformance;
        }
    }
}
