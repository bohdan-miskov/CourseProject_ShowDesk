using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class StageManager
    {
        private List<Stage> stages;
        private readonly StageBaseService database;

        public StageManager(StageBaseService databaseService)
        {
            database = databaseService;
        }

        public List<Stage> Stages
        {
            get
            {
                return stages;
            }
        }

        public async Task LoadFromDatabaseAsync()
        {
            stages = await database.GetAllStagesAsync();
        }

        public Stage GetById(Guid id)
        {
            return stages.FirstOrDefault(s => s.Id == id);
        }

        public async Task AddStageAsync(Stage stage)
        {
            stages.Add(stage);
            await database.AddStageAsync(stage);
        }

        public async Task RemoveStageAsync(Guid id)
        {
            var stage = stages.FirstOrDefault(s => s.Id == id);
            if (stage != null)
            {
                stages.Remove(stage);
                await database.RemoveStageAsync(id);
            }
        }

        public async Task UpdateStageAsync(Stage updatedStage)
        {
            var existingStage = stages.FirstOrDefault(s => s.Id == updatedStage.Id);
            if (existingStage != null)
            {
                int index = stages.IndexOf(existingStage);
                stages[index] = updatedStage;
                await database.UpdateStageAsync(updatedStage);
            }
        }
    }

}
