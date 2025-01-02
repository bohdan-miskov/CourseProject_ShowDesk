using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub.Scripts
{
    public class StandardPlusTicket : Ticket
    {
        protected string drink;

        public StandardPlusTicket()
        {
            typeIncrease = 1.5;
            type = "Standard Plus";
        }

        public StandardPlusTicket(int index, int position, bool reserved, string drink) : base(index, position, reserved)
        {
            this.drink = drink;
            typeIncrease = 1.5;
            type = "Standard Plus";
        }

        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
            }
        }


        public override string GetAdditionalServices()
        {
            return $"Drink: {drink}";
        }

    }
}
