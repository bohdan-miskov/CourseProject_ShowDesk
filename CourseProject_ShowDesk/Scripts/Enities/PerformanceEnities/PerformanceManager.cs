using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities
{
    public class PerformanceManager
    {
        private List<Performance> performances;
        private List<Performance> pastPerformances;
        private readonly PerformanceBaseService database;

        public PerformanceManager(PerformanceBaseService databaseService)
        {
            database = databaseService;
        }
        public List<Performance> Performances
        {
            get
            {
                return performances;
            }
        }
        public List<Performance> PastPerformances
        {
            get
            {
                return pastPerformances;
            }
        }
        public void LoadUpcomingPerformancesFromDatabase()
        {
            database.MovePastPerformances();
            performances = database.GetAllUpcomingPerformances();
        }
        public void LoadPastPerformancesFromDatabase(DateTime startDate, DateTime endDate)
        {
            database.MovePastPerformances();
            pastPerformances = database.GetPastPerformances(startDate,endDate);
        }
        public Performance GetOldestPerformance()
        {
            database.MovePastPerformances();
            return database.GetOldestPerformance();
        }
        public void AddPerformance(Performance perf)
        {
            performances.Add(perf);
            database.AddPerformance(perf);
        }

        public void RemovePerformance(Guid id)
        {
            var perf = performances.FirstOrDefault(p => p.Id == id);
            if (perf != null)
            {
                performances.Remove(perf);
                database.RemovePerformance(id);
            }
        }

        public Performance GetById(Guid id)
        {
            return performances.FirstOrDefault(s => s.Id == id);
        }

        public void UpdatePerformance(Performance updatedPerformance)
        {
            var existingPerformance = performances.FirstOrDefault(s => s.Id == updatedPerformance.Id);
            if (existingPerformance != null)
            {
                int index = performances.IndexOf(existingPerformance);
                performances[index] = updatedPerformance;
                database.UpdatePerformance(updatedPerformance);
            }
        }
    }

}
