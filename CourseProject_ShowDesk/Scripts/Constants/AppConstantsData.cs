using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts
{
    public class AppConstantsData
    {
        private string performancesFileName;
        private string stagesFileName;
        private string employeesFileName;
        private double standardIncrease;
        private double standardPlusIncrease;
        private double premiumIncrease;
        private int rangeDateOfPastPerformances;
        private char currencySymbol;
        private TimeSpan minBreakBetweenPerformance;
        private TimeSpan initialPerformanceDuration;
        private TimeSpan maxDuration;
        private List<string> listOfProfessions;
        private List<string> listOfTicketTypes;
        private List<string> listOfSouvenirs;
        private List<string> listOfDrinks;

        public string PerformancesFileName
        {
            get
            {
                return performancesFileName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Performances file name cannot be null or empty.");
                }
                performancesFileName = value;
            }
        }

        public string StagesFileName
        {
            get
            {
                return stagesFileName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Stages file name cannot be null or empty.");
                }
                stagesFileName = value;
            }
        }

        public string EmployeesFileName
        {
            get
            {
                return employeesFileName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Employees file name cannot be null or empty.");
                }
                employeesFileName = value;
            }
        }

        public double StandardIncrease
        {
            get
            {
                return standardIncrease;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Standard increase cannot be negative.");
                }
                standardIncrease = value;
            }
        }

        public double StandardPlusIncrease
        {
            get
            {
                return standardPlusIncrease;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Standard plus increase cannot be negative.");
                }
                standardPlusIncrease = value;
            }
        }

        public double PremiumIncrease
        {
            get
            {
                return premiumIncrease;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Premium increase cannot be negative.");
                }
                premiumIncrease = value;
            }
        }

        public int RangeDateOfPastPerformances
        {
            get
            {
                return rangeDateOfPastPerformances;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Range date of past performances cannot be negative.");
                }
                rangeDateOfPastPerformances = value;
            }
        }

        public char CurrencySymbol
        {
            get
            {
                return currencySymbol;
            }
            set
            {
                if (!char.IsSymbol(value))
                {
                    throw new ArgumentException("Currency symbol must be a symbol");
                }

                currencySymbol = value;
            }
        }

        public TimeSpan MinBreakBetweenPerformance
        {
            get
            {
                return minBreakBetweenPerformance;
            }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException("Minimum break between performances cannot be negative.");
                }
                minBreakBetweenPerformance = value;
            }
        }

        public TimeSpan InitialPerformanceDuration
        {
            get
            {
                return initialPerformanceDuration;
            }
            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException("Initial performance duration must be greater than zero.");
                }
                initialPerformanceDuration = value;
            }
        }

        public TimeSpan MaxDuration
        {
            get
            {
                return maxDuration;
            }
            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException("Maximum duration must be greater than zero.");
                }
                maxDuration = value;
            }
        }

        public List<string> ListOfProfessions
        {
            get
            {
                return listOfProfessions;
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("List of professions cannot be null or empty.");
                }
                listOfProfessions = value;
            }
        }

        public List<string> ListOfTicketTypes
        {
            get
            {
                return listOfTicketTypes;
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("List of ticket types cannot be null or empty.");
                }
                listOfTicketTypes = value;
            }
        }

        public List<string> ListOfSouvenirs
        {
            get
            {
                return listOfSouvenirs;
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("List of souvenirs cannot be null or empty.");
                }
                listOfSouvenirs = value;
            }
        }

        public List<string> ListOfDrinks
        {
            get
            {
                return listOfDrinks;
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentException("List of drinks cannot be null or empty.");
                }
                listOfDrinks = value;
            }
        }

    }
}
