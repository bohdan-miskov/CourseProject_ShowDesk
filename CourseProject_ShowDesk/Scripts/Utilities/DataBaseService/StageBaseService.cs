using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<List<Stage>> GetAllStagesAsync(bool sortByName = true)
        {
            List<Stage> stages = await stageCollection.Find(_ => true).ToListAsync();
            if (sortByName)
            {
                stages.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            }
            return stages;
        }
        public async Task AddStageAsync(Stage stage)
        {
            await stageCollection.InsertOneAsync(stage);
        }
        public async Task RemoveStageAsync(Guid id)
        {
            var filter = Builders<Stage>.Filter.Eq("Id", id);
            await stageCollection.DeleteOneAsync(filter);
        }
        public async Task UpdateStageAsync(Stage updatedStage)
        {
            var filter = Builders<Stage>.Filter.Eq(p => p.Id, updatedStage.Id);
            await stageCollection.ReplaceOneAsync(filter, updatedStage);
        }
    }
}
