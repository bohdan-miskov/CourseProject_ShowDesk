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
        public const string PerformancesFileName = "performances.json";
        public const string StagesFileName = "stages.json";
        public const string EmployeesFileName = "employees.json";
        public const double StandardIncrease = 1;
        public const double StandardPlusIncrease = 1.5;
        public const double PremiumIncrease = 2;
        public const int RangeDateOfPastPerformances = 7;

        public static readonly TimeSpan MinBreakBetweenPerformance = new TimeSpan(0, 15, 0);
        public static readonly TimeSpan InitialPerformanceDuration = new TimeSpan(1, 30, 0);
        public static readonly TimeSpan MaxDuration = new TimeSpan(5, 0, 0);

        public static readonly List<string> ListOfProfessions = new List<string> { "Director", "Administrator", "Cashier" };
        public static readonly List<string> ListOfTicketTypes = new List<string> { "Standard", "StandardPlus", "Premium" };
        public static readonly List<string> ListOfSouvenirs = new List<string> { "Poster", "Mask", "Book", "Coulomb" };
        public static readonly List<string> ListOfDrinks = new List<string> {"Water", "Coffee", "Tea", "Juice" };
    }
}
