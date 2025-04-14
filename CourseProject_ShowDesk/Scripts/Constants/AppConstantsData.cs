using System;
using System.Collections.Generic;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public class AppConstantsData
    {
        private string companyName;
        private string generalCollectionName;
        private string performancesCollectionName;
        private string pastPerformancesCollectionName;
        private string stagesCollectionName;
        private string employeesCollectionName;
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
        private char passwordChar;
        private bool isPrintReceipt;
        private string savePathReceipt;
        private string connectionString;
        private int updateEmployeesInterval;
        private int updateStagesInterval;
        private int updatePerformancesInterval;
        private int updateTicketsInterval;
        private Color seatBaseColor;
        public static Color seatHoverColor;

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Company name cannot be null or empty.");
                }
                companyName = value;
            }
        }
        public string GeneralCollectionName
        {
            get
            {
                return generalCollectionName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("General file name cannot be null or empty.");
                }
                generalCollectionName = value;
            }
        }
        public string PerformancesCollectionName
        {
            get
            {
                return performancesCollectionName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Performances file name cannot be null or empty.");
                }
                performancesCollectionName = value;
            }
        }
        public string PastPerformancesCollectionName
        {
            get
            {
                return pastPerformancesCollectionName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Performances file name cannot be null or empty.");
                }
                pastPerformancesCollectionName = value;
            }
        }

        public string StagesCollectionName
        {
            get
            {
                return stagesCollectionName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Stages file name cannot be null or empty.");
                }
                stagesCollectionName = value;
            }
        }

        public string EmployeesCollectionName
        {
            get
            {
                return employeesCollectionName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Employees file name cannot be null or empty.");
                }
                employeesCollectionName = value;
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
        public char PasswordChar
        {
            get
            {
                return passwordChar;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("PasswordCypher cannot be null or empty.");
                }
                passwordChar = value;
            }
        }

        public bool IsPrintReceipt
        {
            get
            {
                return isPrintReceipt;
            }
            set
            {
                isPrintReceipt = value;
            }
        }

        public string SavePathReceipt
        {
            get
            {
                return savePathReceipt;
            }
            set
            {
                savePathReceipt = value;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ConnectionString cannot be null or empty.");
                }
                connectionString = value;
            }
        }

        public int UpdateEmployeesInterval
        {
            get
            {
                return updateEmployeesInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("UpdateEmployeesInterval cannot be negative.");
                }
                updateEmployeesInterval = value;
            }
        }

        public int UpdateStagesInterval
        {
            get
            {
                return updateStagesInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("UpdateStagesInterval cannot be negative.");
                }
                updateStagesInterval = value;
            }
        }

        public int UpdatePerformancesInterval
        {
            get
            {
                return updatePerformancesInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("UpdatePerformancesInterval cannot be negative.");
                }
                updatePerformancesInterval = value;
            }
        }

        public int UpdateTicketsInterval
        {
            get
            {
                return updateTicketsInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("UpdateTicketsInterval cannot be negative.");
                }
                updateTicketsInterval = value;
            }
        }

        public Color SeatBaseColor
        {
            get
            {
                return seatBaseColor;
            }
            set
            {
                seatBaseColor = value;
            }
        }

        public Color SeatHoverColor
        {
            get
            {
                return seatHoverColor;
            }
            set
            {
                seatHoverColor = value;
            }
        }


    }
}
