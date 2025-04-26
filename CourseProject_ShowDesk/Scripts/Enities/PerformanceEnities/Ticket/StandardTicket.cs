using CourseProject_ShowDesk.Scripts.Constants;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket
{
    [Serializable]
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(StandardPlusTicket))]
    public class StandardTicket
    {
        [BsonId]
        protected Guid id = Guid.NewGuid();
        protected int position;
        protected double calculatedPrice;
        protected bool reserved;
        protected string type;
        protected double typeIncrease;

        public StandardTicket()
        {
            reserved = false;
            type = AppConstants.ListOfTicketTypes[0];
            typeIncrease = AppConstants.StandardIncrease;
        }
        public StandardTicket(int position, bool reserved)
        {
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

            if (increase < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(increase), "Price increase factor cannot be negative.");
            }
            calculatedPrice = (price * increase) + typeIncrease;
        }

        public virtual string GetAdditionalServices()
        {
            return "None";
        }
    }
}


