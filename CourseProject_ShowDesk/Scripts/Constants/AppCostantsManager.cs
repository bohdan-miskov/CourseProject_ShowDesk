using CourseProject_ShowDesk.Scripts.Utilities.FileService;
using System.IO;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public static class AppCostantsManager
    {
        private static readonly string appConstantsFileName = "appConstants.json";

        public static void LoadAppConstantsFromFile()
        {
            if (File.Exists(appConstantsFileName))
            {
                try
                {
                    AppConstantsData appConstantsData = FileHandler.LoadElementFromJson<AppConstantsData>(appConstantsFileName);

                    AppConstants.PopulateConstants(appConstantsData);
                }
                catch
                {
                    throw new InvalidDataException($"Error in work with fields of {appConstantsFileName}");
                }
            }
            else
            {
                throw new FileNotFoundException($"The configuration file '{appConstantsFileName}' was not found.");
            }
        }

        public static void SaveAppConstantsToFile(AppConstantsData constantsData)
        {
            FileHandler.SaveElementToJson(appConstantsFileName, constantsData);

            AppConstants.PopulateConstants(constantsData);
        }
    }
}

