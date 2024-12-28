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
        protected int index;          
        protected int position;         
        protected double calculatedPrice; 
        protected bool reserved;   

        public Ticket()
        {
            index = 0;
            position = -1;
            calculatedPrice = 0.0;
            reserved = false;
        }
        public Ticket(int index, int position, double calculatedPrice, bool reserved)
        {
            this.index = index;
            this.position = position;
            this.calculatedPrice = calculatedPrice;
            this.reserved = reserved;
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
                position = (value < 0) ? 0 : value;
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

        public void ChangeStatus()
        {
            reserved = !reserved;
        }

        public void CalculatePrice(double basePrice, double increase)
        {
            calculatedPrice = basePrice * increase;
        }
    }
    
    
}


