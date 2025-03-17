using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts
{
    public static class AppConstants
    {
        public static string PerformancesFileName { get; private set; }
        public static string StagesFileName { get; private set; }
        public static string EmployeesFileName { get; private set; }

        public static double StandardIncrease { get; private set; }
        public static double StandardPlusIncrease { get; private set; } 
        public static double PremiumIncrease { get; private set; }

        public static int RangeDateOfPastPerformances { get; private set; } 

        public static char CurrencySymbol { get; private set;}
            
        public static TimeSpan MinBreakBetweenPerformance { get; private set; } 
        public static TimeSpan InitialPerformanceDuration { get; private set; }
        public static TimeSpan MaxDuration { get; private set; } 

        public static List<string> ListOfProfessions { get; private set; } 
        public static List<string> ListOfTicketTypes { get; private set; } 
        public static List<string> ListOfSouvenirs { get; private set; } 
        public static List<string> ListOfDrinks { get; private set; }
        public static readonly string ConnectionString =  "mongodb+srv://bohdanmiskov07:7XRSvDHvZt2rL6gr@showdesk.tqctr.mongodb.net/?retryWrites=true&w=majority&appName=ShowDesk";



        public static void PopulateConstants(AppConstantsData constantsData)
        {
            PerformancesFileName = constantsData.PerformancesFileName;
            StagesFileName = constantsData.StagesFileName;
            EmployeesFileName= constantsData.EmployeesFileName;
            StandardIncrease = constantsData.StandardIncrease;
            StandardPlusIncrease = constantsData.StandardPlusIncrease;
            PremiumIncrease = constantsData.PremiumIncrease;
            RangeDateOfPastPerformances = constantsData.RangeDateOfPastPerformances;
            CurrencySymbol = constantsData.CurrencySymbol;

            MinBreakBetweenPerformance = constantsData.MinBreakBetweenPerformance;
            InitialPerformanceDuration = constantsData.InitialPerformanceDuration;
            MaxDuration = constantsData.MaxDuration;

            ListOfProfessions = constantsData.ListOfProfessions;
            ListOfTicketTypes=constantsData.ListOfTicketTypes;
            ListOfSouvenirs = constantsData.ListOfSouvenirs;
            ListOfDrinks = constantsData.ListOfDrinks;
        }

        public static AppConstantsData CloneConstants()
        {
            return  new AppConstantsData
            {
                PerformancesFileName = AppConstants.PerformancesFileName,
                StagesFileName = AppConstants.StagesFileName,
                EmployeesFileName = AppConstants.EmployeesFileName,
                StandardIncrease = AppConstants.StandardIncrease,
                StandardPlusIncrease = AppConstants.StandardPlusIncrease,
                PremiumIncrease = AppConstants.PremiumIncrease,
                RangeDateOfPastPerformances = AppConstants.RangeDateOfPastPerformances,
                CurrencySymbol=AppConstants.CurrencySymbol,
                MinBreakBetweenPerformance = AppConstants.MinBreakBetweenPerformance,
                InitialPerformanceDuration = AppConstants.InitialPerformanceDuration,
                MaxDuration = AppConstants.MaxDuration,
                ListOfProfessions = new List<string>(AppConstants.ListOfProfessions),
                ListOfTicketTypes = new List<string>(AppConstants.ListOfTicketTypes),
                ListOfSouvenirs = new List<string>(AppConstants.ListOfSouvenirs),
                ListOfDrinks = new List<string>(AppConstants.ListOfDrinks)
            };
        }

    }


}
