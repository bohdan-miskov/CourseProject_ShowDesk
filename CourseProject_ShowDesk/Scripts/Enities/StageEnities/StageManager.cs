using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class StageManager
    {
        private List<Stage> stages;
        private readonly StageBaseService database;

        public StageManager(StageBaseService databaseService)
        {
            database = databaseService;
            LoadFromDatabase();
        }

        public List<Stage> Stages
        {
            get
            {
                return stages;
            }
        }

        public void LoadFromDatabase()
        {
            stages = database.GetAllStages();
        }

        public Stage GetById(Guid id)
        {
            return stages.FirstOrDefault(s => s.Id == id);
        }

        public void AddStage(Stage stage)
        {
            stages.Add(stage);
            database.AddStage(stage);
        }

        public void RemoveStage(Guid id)
        {
            var stage = stages.FirstOrDefault(s => s.Id == id);
            if (stage != null)
            {
                stages.Remove(stage);
                database.RemoveStage(id);
            }
        }

        public void UpdateStage(Stage updatedStage)
        {
            var existingStage = stages.FirstOrDefault(s => s.Id == updatedStage.Id);
            if (existingStage != null)
            {
                int index = stages.IndexOf(existingStage);
                stages[index] = updatedStage;
                database.UpdateStage(updatedStage);
            }
        }
    }

}
