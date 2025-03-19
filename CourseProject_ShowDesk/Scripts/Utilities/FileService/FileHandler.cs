using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CourseProject_ShowDesk.Scripts.Utilities.FileService
{
    public class FileHandler
    {
        public static void SaveListToJson<T>(string fileName, List<T> objects)
        {
            string jsonData = JsonConvert.SerializeObject(objects, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, jsonData);
        }

        public static List<T> LoadListFromJson<T>(string fileName)
        {
            string jsonData = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(jsonData, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }

        public static void SaveElementToJson<T>(string fileName, T element)
        {
            string jsonData = JsonConvert.SerializeObject(element, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, jsonData);
        }

        public static T LoadElementFromJson<T>(string fileName)
        {
            string jsonData = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(jsonData, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }

    }
}
