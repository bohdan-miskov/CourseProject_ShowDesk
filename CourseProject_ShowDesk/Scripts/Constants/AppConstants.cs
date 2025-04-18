using System;
using System.Collections.Generic;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public static class AppConstants
    {
        public static DateTime FirstLog { get; private set; } = DateTime.MinValue; 

        public static string CompanyName { get; private set; } = "«ShowDesk»";
        public static string GeneralCollectionName { get; private set; } = "Event";
        public static string PerformancesCollectionName { get; private set; } = "UpcomingPerformances";
        public static string PastPerformancesCollectionName { get; private set; } = "PastPerformances";
        public static string StagesCollectionName { get; private set; } = "Stages";
        public static string EmployeesCollectionName { get; private set; } = "Employees";

        public static double StandardIncrease { get; private set; } = 1;
        public static double StandardPlusIncrease { get; private set; } = 1.5;
        public static double PremiumIncrease { get; private set; } = 3;

        public static char CurrencySymbol { get; private set; } = '$';

        public static TimeSpan MinBreakBetweenPerformance { get; private set; } = new TimeSpan(0, 15, 0);
        public static TimeSpan InitialPerformanceDuration { get; private set; } = new TimeSpan(1, 30, 0);
        public static TimeSpan MaxDuration { get; private set; } = new TimeSpan(5, 0, 0);

        public static List<string> ListOfProfessions { get; private set; } = new List<string> { "Director", "Administrator", "Cashier" };
        public static List<string> ListOfTicketTypes { get; private set; } = new List<string> { "Standard", "StandardPlus", "Premium" };
        public static List<string> ListOfSouvenirs { get; private set; } = new List<string> { "Poster", "Mask", "Book", "Coulomb" };
        public static List<string> ListOfDrinks { get; private set; } = new List<string> { "Water", "Coffee", "Tea", "Juice" };

        public static char PasswordChar { get; private set; } = '*';

        public static bool IsPrintReceipt { get; private set; } = true;
        public static string SavePathReceipt { get; private set; } = "C:\\Users\\Fujitsu\\Documents\\Tickets";

        public static string ConnectionString { get; private set; } = "mongodb+srv://bohdanmiskov07:7XRSvDHvZt2rL6gr@showdesk.tqctr.mongodb.net/?retryWrites=true&w=majority&appName=ShowDesk";
        public static int UpdateEmployeesInterval { get; private set; } = 300000;
        public static int UpdateStagesInterval { get; private set; } = 300000;
        public static int UpdatePerformancesInterval { get; private set; } = 300000;
        public static int UpdateTicketsInterval { get; private set; } = 60000;

        public static Color SeatBaseColor { get; private set; } = Color.LightGray;
        public static Color SeatHoverColor { get; private set; } = Color.GreenYellow;

        public static void SetFirstLog()
        {
            FirstLog = DateTime.Now;
        }

        public static void PopulateConstants(AppConstantsData constantsData)
        {
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
