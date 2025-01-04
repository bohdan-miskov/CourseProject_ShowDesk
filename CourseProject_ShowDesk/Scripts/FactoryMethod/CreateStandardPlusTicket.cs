using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.FactoryMethod
{
    public class CreateStandardPlusTicket:ICreateTicket
    {
        private string drink;
        public CreateStandardPlusTicket(string drink) 
        {
            this.drink = drink;
        }

        public StandardTicket CreateTicket()
        {
            return new StandardPlusTicket
            {
                Drink = drink
            };
        }
    }
}
