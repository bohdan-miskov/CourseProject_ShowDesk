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
        public static string PerformancesFileName { get; private set; } = "performances.json";
        public static string StagesFileName = "stages.json";
        public static string EmployeesFileName = "employees.json";
        public static double StandardIncrease = 1;
        public static double StandardPlusIncrease = 1.5;
        public static double PremiumIncrease = 3;
        public static int RangeDateOfPastPerformances = 7;

        public static TimeSpan MinBreakBetweenPerformance = new TimeSpan(0, 15, 0);
        public static TimeSpan InitialPerformanceDuration = new TimeSpan(1, 30, 0);
        public static TimeSpan MaxDuration = new TimeSpan(5, 0, 0);

        public static List<string> ListOfProfessions = new List<string> { "Director", "Administrator", "Cashier" };
        public static List<string> ListOfTicketTypes = new List<string> { "Standard", "StandardPlus", "Premium" };
        public static List<string> ListOfSouvenirs = new List<string> { "Poster", "Mask", "Book", "Coulomb" };
        public static List<string> ListOfDrinks = new List<string> {"Water", "Coffee", "Tea", "Juice" };
    }
}
