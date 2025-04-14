using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

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
            }
            catch
            {
                throw new DatabaseConnectionException("Could not connect to the database.");
            }
        }
        public List<Stage> GetAllStages()
        {
            return stageCollection.Find(_ => true).ToList();
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
    }
}
