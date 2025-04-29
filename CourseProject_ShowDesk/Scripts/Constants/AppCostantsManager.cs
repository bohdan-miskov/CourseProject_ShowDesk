using CourseProject_ShowDesk.Scripts.Utilities.FileService;
using DotNetEnv;
using System;
using System.IO;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public static class AppCostantsManager
    {
        private static readonly string appConstantsFileName = "appConstants.json";

        public static void LoadAppConstantsFromFile()
        {
            if (!File.Exists(appConstantsFileName))
            {
                throw new FileNotFoundException($"The configuration file '{appConstantsFileName}' was not found.");
            }

            try
            {
                AppConstantsData appConstantsData = FileHandler.LoadElementFromJson<AppConstantsData>(appConstantsFileName);
                if (string.IsNullOrEmpty(appConstantsData.ConnectionString))
                {
                    string envPath = "D:\\Коледж\\Курсова робота 3курс\\CourseProject_ShowDesk\\CourseProject_ShowDesk\\.env";
                    Env.Load(envPath);
                    string connectionStr = Environment.GetEnvironmentVariable("DATABASE_URL");
                    appConstantsData.ConnectionString = connectionStr;
                }
                AppConstants.PopulateConstants(appConstantsData);
            }
            catch
            {
                throw new InvalidDataException($"Error in work with fields of {appConstantsFileName}");
            }
        }

        public static void SaveAppConstantsToFile(AppConstantsData constantsData)
        {
            FileHandler.SaveElementToJson(appConstantsFileName, constantsData);

            AppConstants.PopulateConstants(constantsData);
        }
    }
}

