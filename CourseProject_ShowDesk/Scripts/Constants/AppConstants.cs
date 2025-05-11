using System;
using System.Collections.Generic;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public static class AppConstants
    {
        public static DateTime FirstLog { get; private set; }

        public static string CompanyName { get; private set; }
        public static string GeneralCollectionName { get; private set; }
        public static string PerformancesCollectionName { get; private set; }
        public static string PastPerformancesCollectionName { get; private set; }
        public static string StagesCollectionName { get; private set; }
        public static string EmployeesCollectionName { get; private set; }

        public static double StandardIncrease { get; private set; }
        public static double StandardPlusIncrease { get; private set; }
        public static double PremiumIncrease { get; private set; }

        public static char CurrencySymbol { get; private set; }

        public static TimeSpan MinBreakBetweenPerformance { get; private set; }
        public static TimeSpan InitialPerformanceDuration { get; private set; }
        public static TimeSpan MaxDuration { get; private set; }

        public static List<string> ListOfProfessions { get; private set; }
        public static List<string> ListOfTicketTypes { get; private set; }
        public static List<string> ListOfSouvenirs { get; private set; }
        public static List<string> ListOfDrinks { get; private set; }

        public static char PasswordChar { get; private set; }

        public static bool IsPrintReceipt { get; private set; }
        public static string SavePathReceipt { get; private set; }

        public static string ConnectionString { get; private set; }
        public static int UpdateEmployeesInterval { get; private set; }
        public static int UpdateStagesInterval { get; private set; }
        public static int UpdatePerformancesInterval { get; private set; }
        public static int UpdateTicketsInterval { get; private set; }

        public static Color SeatBaseColor { get; private set; }
        public static Color SeatHoverColor { get; private set; }


        public static void SetFirstLog()
        {
            FirstLog = DateTime.Now;
        }

        public static void PopulateConstants(AppConstantsData constantsData)
        {
            FirstLog = constantsData.FirstLog;

            CompanyName = constantsData.CompanyName;
            GeneralCollectionName = constantsData.GeneralCollectionName;
            PastPerformancesCollectionName = constantsData.PastPerformancesCollectionName;
            PerformancesCollectionName = constantsData.PerformancesCollectionName;
            StagesCollectionName = constantsData.StagesCollectionName;
            EmployeesCollectionName = constantsData.EmployeesCollectionName;

            StandardIncrease = constantsData.StandardIncrease;
            StandardPlusIncrease = constantsData.StandardPlusIncrease;
            PremiumIncrease = constantsData.PremiumIncrease;

            CurrencySymbol = constantsData.CurrencySymbol;

            MinBreakBetweenPerformance = constantsData.MinBreakBetweenPerformance;
            InitialPerformanceDuration = constantsData.InitialPerformanceDuration;
            MaxDuration = constantsData.MaxDuration;

            ListOfProfessions = new List<string>(constantsData.ListOfProfessions);
            ListOfTicketTypes = new List<string>(constantsData.ListOfTicketTypes);
            ListOfSouvenirs = new List<string>(constantsData.ListOfSouvenirs);
            ListOfDrinks = new List<string>(constantsData.ListOfDrinks);

            PasswordChar = constantsData.PasswordChar;
            IsPrintReceipt = constantsData.IsPrintReceipt;
            SavePathReceipt = constantsData.SavePathReceipt;

            ConnectionString = constantsData.ConnectionString;
            UpdateEmployeesInterval = constantsData.UpdateEmployeesInterval;
            UpdateStagesInterval = constantsData.UpdateStagesInterval;
            UpdatePerformancesInterval = constantsData.UpdatePerformancesInterval;
            UpdateTicketsInterval = constantsData.UpdateTicketsInterval;

            SeatBaseColor = constantsData.SeatBaseColor;
            SeatHoverColor = constantsData.SeatHoverColor;
        }

        public static AppConstantsData CloneConstants()
        {
            return new AppConstantsData
            {
                FirstLog = FirstLog,

                CompanyName = CompanyName,
                GeneralCollectionName = GeneralCollectionName,
                PastPerformancesCollectionName = PastPerformancesCollectionName,
                PerformancesCollectionName = PerformancesCollectionName,
                StagesCollectionName = StagesCollectionName,
                EmployeesCollectionName = EmployeesCollectionName,

                StandardIncrease = StandardIncrease,
                StandardPlusIncrease = StandardPlusIncrease,
                PremiumIncrease = PremiumIncrease,

                CurrencySymbol = CurrencySymbol,

                MinBreakBetweenPerformance = MinBreakBetweenPerformance,
                InitialPerformanceDuration = InitialPerformanceDuration,
                MaxDuration = MaxDuration,

                ListOfProfessions = new List<string>(ListOfProfessions),
                ListOfTicketTypes = new List<string>(ListOfTicketTypes),
                ListOfSouvenirs = new List<string>(ListOfSouvenirs),
                ListOfDrinks = new List<string>(ListOfDrinks),

                PasswordChar = PasswordChar,
                IsPrintReceipt = IsPrintReceipt,
                SavePathReceipt = SavePathReceipt,

                ConnectionString = ConnectionString,
                UpdateEmployeesInterval = UpdateEmployeesInterval,
                UpdateStagesInterval = UpdateStagesInterval,
                UpdatePerformancesInterval = UpdatePerformancesInterval,
                UpdateTicketsInterval = UpdateTicketsInterval,

                SeatBaseColor = SeatBaseColor,
                SeatHoverColor = SeatHoverColor
            };
        }
    }
}
