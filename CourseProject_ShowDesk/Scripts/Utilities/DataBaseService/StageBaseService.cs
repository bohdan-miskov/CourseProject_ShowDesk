using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService
{
    public class StageBaseService
    {
        private readonly IMongoCollection<Stage> stageCollection;

        public StageBaseService(string dbName = "Event")
        {
            var client = new MongoClient(AppConstants.ConnectionString);
            var db = client.GetDatabase(dbName);

            stageCollection = db.GetCollection<Stage>("Stages");
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
            var filter = Builders<Stage>.Filter.Eq(p => p.Index, updatedStage.Index);
            stageCollection.ReplaceOne(filter, updatedStage);
        }
    }
}
