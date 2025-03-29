using CourseProject_ShowDesk.Scripts.Utilities.FileService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                AppConstantsData appConstantsData = FileHandler.LoadElementFromJson<AppConstantsData>(appConstantsFileName);

                AppConstants.PopulateConstants(appConstantsData);
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

