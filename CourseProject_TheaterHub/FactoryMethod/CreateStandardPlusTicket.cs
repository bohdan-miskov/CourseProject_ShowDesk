using CourseProject_TheaterHub.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub.FactoryMethod
{
    public class CreateStandardPlusTicket:ICreateTicket
    {
        private string drink;
        public CreateStandardPlusTicket(string drink) 
        {
            this.drink = drink;
        }

        public Ticket CreateTicket()
        {
            return new StandardPlusTicket
            {
                Drink = drink
            };
        }
    }
}
