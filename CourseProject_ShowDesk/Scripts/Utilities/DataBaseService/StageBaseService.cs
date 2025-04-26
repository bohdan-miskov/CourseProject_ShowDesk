using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService
{
    public class StageBaseService
    {
        private readonly IMongoCollection<Stage> stageCollection;

        public StageBaseService()
        {
            try
            {
                var client = new MongoClient(AppConstants.ConnectionString);
                var db = client.GetDatabase(AppConstants.GeneralCollectionName);
                var test = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Result;

                stageCollection = db.GetCollection<Stage>(AppConstants.StagesCollectionName);

                RemoveFieldFromDataBase("Enabled");
            }
            catch
            {
                throw new DatabaseConnectionException("Could not connect to the database.");
            }
        }
        public List<Stage> GetAllStages(bool sortByName = true)
        {
            List<Stage> stages = stageCollection.Find(_ => true).ToList();
            if (sortByName)
            {
                stages.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            }
            return stages;
        }
        public void AddStage(Stage stage)
        {
            stageCollection.InsertOne(stage);
        }
        public void RemoveStage(Guid id)
        {
            var filter = Builders<Stage>.Filter.Eq("Id", id);
            stageCollection.DeleteOne(filter);
        }
        public void UpdateStage(Stage updatedStage)
        {
            var filter = Builders<Stage>.Filter.Eq(p => p.Id, updatedStage.Id);
            stageCollection.ReplaceOne(filter, updatedStage);
        }

        public void RemoveFieldFromDataBase(string fieldName)
        {
            var update = Builders<Stage>.Update.Unset("ScaleFactor");
            stageCollection.UpdateMany(Builders<Stage>.Filter.Empty, update);
            //var update2 = Builders<Stage>.Update.Unset("DecorList.$[].BorderStyle");
            //stageCollection.UpdateMany(Builders<Stage>.Filter.Empty, update2);
            //List<Stage> stages = stageCollection.Find(_ => true).ToList();

            //foreach (var stage in stages)
            //{

            //    var cleanedSeats = new List<BsonDocument>();
            //    foreach (var seat in stage.SeatList)
            //    {
            //        var bsonSeat = seat.ToBsonDocument();
            //        bsonSeat.Remove(fieldName);
            //        cleanedSeats.Add(bsonSeat);
            //    }


            //    var update = Builders<Stage>.Update.Set("SeatList", cleanedSeats);
            //    stageCollection.UpdateOne(s => s.Id == stage.Id, update);
            //}
        }
    }
}
