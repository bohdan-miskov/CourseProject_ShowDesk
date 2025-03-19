using CourseProject_ShowDesk.Scripts;
using System;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket
{
    [Serializable]

    public class StandardTicket
    {
        protected readonly Guid id = Guid.NewGuid();
        protected int index;
        protected int position;
        protected double calculatedPrice;
        protected bool reserved;
        protected string type;
        protected double typeIncrease;

        public StandardTicket()
        {
            index = 0;
            position = 0;
            calculatedPrice = 0.0;
            reserved = false;
            //type = AppConstants.ListOfTicketTypes[0];
            //typeIncrease = AppConstants.StandardIncrease;
        }
        public StandardTicket(int index, int position, bool reserved)
        {
            Index = index;
            Position = position;
            Reserved = reserved;
        }
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(Index), $"The Ticket ID must be between 0 and {int.MaxValue}.");
                }
                index = value;
            }
        }
        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Position), "Position cannot be negative.");
                }
                position = value;
            }
        }
        public double CalculatedPrice
        {
            get
            {
                return calculatedPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(CalculatedPrice), "Calculated price cannot be negative.");
                }
                calculatedPrice = value;
            }
        }
        public bool Reserved
        {
            get
            {
                return reserved;
            }
            set
            {
                reserved = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ticket type cannot be null, empty, or whitespace.", nameof(Type));
                }
                type = value;
            }
        }
        public void ChangeStatus()
        {
            reserved = !reserved;
        }

        public void CalculatePrice(double price, double increase)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(price), "Base price cannot be negative.");
            }

            if (increase <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(increase), "Price increase factor must be greater than 0.");
            }
            calculatedPrice = price + (price * increase / 100) + (price * (typeIncrease-1));
        }

        public virtual string GetAdditionalServices()
        {
            return "None";
        }

    }
}


