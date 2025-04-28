using System;
using System.Collections.Generic;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Constants
{
    public class AppConstantsData
    {
        private static DateTime firstLog = DateTime.MinValue;

        private string companyName = "«ShowDesk»";
        private string generalCollectionName = "Event";
        private string performancesCollectionName = "UpcomingPerformances";
        private string pastPerformancesCollectionName = "PastPerformances";
        private string stagesCollectionName = "Stages";
        private string employeesCollectionName = "Employees";

        private double standardIncrease = 0;
        private double standardPlusIncrease = 10;
        private double premiumIncrease = 30;

        private char currencySymbol = '$';

        private TimeSpan minBreakBetweenPerformance = new TimeSpan(0, 15, 0);
        private TimeSpan initialPerformanceDuration = new TimeSpan(1, 30, 0);
        private TimeSpan maxDuration = new TimeSpan(5, 0, 0);

        private List<string> listOfProfessions = new List<string> { "Director", "Administrator", "Cashier" };
        private List<string> listOfTicketTypes = new List<string> { "Standard", "StandardPlus", "Premium" };
        private List<string> listOfSouvenirs = new List<string> { "Poster", "Mask", "Book", "Coulomb" };
        private List<string> listOfDrinks = new List<string> { "Water", "Coffee", "Tea", "Juice" };

        private char passwordChar = '*';

        private bool isPrintReceipt = true;
        private string savePathReceipt = "C:\\Users\\Fujitsu\\Documents\\Tickets";

        private string connectionString;

        private int updateEmployeesInterval = 300000;
        private int updateStagesInterval = 300000;
        private int updatePerformancesInterval = 300000;
        private int updateTicketsInterval = 60000;

        private Color seatBaseColor = Color.LightGray;
        public static Color seatHoverColor = Color.GreenYellow;

        public DateTime FirstLog
        {
            get
            {
                return firstLog;
            }
            set
            {
                if (value!=null)
                {
                    firstLog=value;
                }
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                companyName = value;
                }
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    generalCollectionName = value;
                }
                
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    performancesCollectionName = value;
                }
                
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    pastPerformancesCollectionName = value;
                }
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                     stagesCollectionName = value;
                }
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    employeesCollectionName = value;
                }
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
                if (value >= 0)
                {
                    standardIncrease = value;
                }
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
                if (value >= 0)
                {
                    standardPlusIncrease = value;
                }
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
                if (value >= 0)
                {
                    premiumIncrease = value;
                }
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
                if (char.IsSymbol(value))
                {
                    currencySymbol = value;
                }
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
                if (value >= TimeSpan.Zero)
                {
                    minBreakBetweenPerformance = value;
                }
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
                if (value > TimeSpan.Zero)
                {
                    initialPerformanceDuration = value;
                }
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
                if (value > TimeSpan.Zero)
                {
                    maxDuration = value;
                }
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
                if (value != null && value.Count > 0)
                {
                    listOfProfessions = new List<string>(value);
                }
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
                if (value != null && value.Count > 0)
                {
                    listOfTicketTypes = new List<string>(value);
                }
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
                if (value != null && value.Count > 0)
                {
                    listOfSouvenirs = new List<string>(value);
                }
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
                if (value != null && value.Count > 0)
                {
                    listOfDrinks = new List<string>(value);
                }
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
                if (!string.IsNullOrWhiteSpace(value.ToString()))
                {
                    passwordChar = value;
                }
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    savePathReceipt = value;
                }
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    connectionString = value;
                }
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
                if (value >= 0)
                {
                    updateEmployeesInterval = value;
                }
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
                if (value >= 0)
                {
                    updateStagesInterval = value;
                }
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
                if (value >= 0)
                {
                    updatePerformancesInterval = value;
                }
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
                if (value >= 0)
                {
                    updateTicketsInterval = value;
                }
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
