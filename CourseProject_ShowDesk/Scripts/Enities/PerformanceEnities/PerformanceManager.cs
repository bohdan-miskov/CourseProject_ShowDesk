using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task LoadUpcomingPerformancesFromDatabaseAsync()
        {
            await database.MovePastPerformancesAsync();
            performances = await database.GetAllUpcomingPerformancesAsync();
        }
        public async Task LoadPastPerformancesFromDatabaseAsync(DateTime startDate, DateTime endDate)
        {
            await database.MovePastPerformancesAsync();
            pastPerformances = await database.GetPastPerformancesAsync(startDate, endDate);
        }
        public async Task LoadAllPastPerformancesFromDatabaseAsync()
        {
            await database.MovePastPerformancesAsync();
            pastPerformances = await database.GetAllPastPerformancesAsync();
        }
        public void ResetPastPerformancesList()
        {
            pastPerformances = null;
        }
        public async Task<Performance> GetOldestPerformanceAsync()
        {
            await database.MovePastPerformancesAsync();
            return await database.GetOldestPerformanceAsync();
        }
        public async Task AddPerformanceAsync(Performance perf)
        {
            performances.Add(perf);
            await database.AddPerformanceAsync(perf);
        }

        public async Task RemovePerformanceAsync(Guid id)
        {
            var perf = performances.FirstOrDefault(p => p.Id == id);
            if (perf != null)
            {
                performances.Remove(perf);
                await database.RemovePerformanceAsync(id);
            }
        }

        public Performance GetById(Guid id)
        {
            return performances.FirstOrDefault(s => s.Id == id);
        }

        public async Task UpdatePerformanceAsync(Performance updatedPerformance)
        {
            var existingPerformance = performances.FirstOrDefault(s => s.Id == updatedPerformance.Id);
            if (existingPerformance != null)
            {
                int index = performances.IndexOf(existingPerformance);
                performances[index] = updatedPerformance;
                await database.UpdatePerformanceAsync(updatedPerformance);
            }
        }
    }

}
