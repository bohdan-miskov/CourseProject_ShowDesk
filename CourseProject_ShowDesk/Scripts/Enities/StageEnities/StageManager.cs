using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class StageManager
    {
        private List<Stage> stages;
        private StageBaseService database;

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
        public int CreateIndex()
        {
            if (stages.Count == 0)
            {
                return 1;
            }

            bool isRepeat;
            for (int i = 1; i < int.MaxValue; i++)
            {
                isRepeat = false;
                for (int j = 0; j < stages.Count; j++)
                {
                    if (i == stages[j].Index)
                    {
                        isRepeat = true;
                        break;
                    }
                }
                if (!isRepeat)
                {
                    
                    return i; 
                }
            }

            return 0;
        }
    }

}
