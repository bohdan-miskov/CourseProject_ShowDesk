using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub
{
    [Serializable]

    public class Ticket
    {
        private int index;          
        private int position;         
        private double calculatedPrice; 
        private bool reserved;
        private string type;
        private double typeIncrease = 1;

        public Ticket()
        {
            index = 0;
            position = -1;
            calculatedPrice = 0.0;
            reserved = false;
        }
        public Ticket(int index, int position, bool reserved, string type)
        {
            this.index = index;
            this.position = position;
            this.reserved = reserved;
            this.type = type;
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
                    throw new ArgumentOutOfRangeException($"The Ticket ID value must be between 0 and {int.MaxValue}");
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
                position = (value < 0) ? -1 : value;
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
                calculatedPrice = (value < 0) ? -1 : value;
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
                type = (value == "Standard" || value == "Standard Plus" || value == "Premium") ? value : "Standard";
            }
        }

        private void CalculateTypeIcrease()
        {
            if (type == "Standard") typeIncrease = 1;
            else if (type == "Standard Plus") typeIncrease = 1.5;
            else if (type == "Premium") typeIncrease = 3;
        }

        public void ChangeStatus()
        {
            reserved = !reserved;
        }

        public void CalculatePrice(double basePrice, double increase)
        {
            CalculateTypeIcrease();
            calculatedPrice= basePrice * increase * typeIncrease;
        }
    }
    
    
}


