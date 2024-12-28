using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub
{
    public class FileHandler
    {
        public static void SavePerformancesToJson(string fileName, List<Performance> performances)
        {
            string jsonPerformances = JsonConvert.SerializeObject(performances, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, jsonPerformances);
        }

        public static List<Performance> LoadPerformancesFromJson(string fileName)
        {
            var jsonPerformances = JsonConvert.DeserializeObject<List<Performance>>(File.ReadAllText(fileName), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            return jsonPerformances;
        }

        public static void SaveStagesToJson(string fileName, List<Stage> stages)
        {
            string jsonStages = JsonConvert.SerializeObject(stages, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, jsonStages);
        }

        public static List<Stage> LoadStagesFromJson(string fileName)
        {
            var jsonStages = JsonConvert.DeserializeObject<List<Stage>>(File.ReadAllText(fileName), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            return jsonStages;
        }

    }
}
