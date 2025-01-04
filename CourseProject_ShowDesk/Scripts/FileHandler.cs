using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CourseProject_ShowDesk
{
    public class FileHandler
    {
        public static void SaveToJson<T>(string fileName, List<T> objects)
        {
            string jsonData = JsonConvert.SerializeObject(objects, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, jsonData);
        }

        public static List<T> LoadFromJson<T>(string fileName)
        {
            string jsonData = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(jsonData, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }

    }
}
