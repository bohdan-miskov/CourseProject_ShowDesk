using CourseProject_TheaterHub.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub.FactoryMethod
{
    public class CreatePremiumTicket:ICreateTicket
    {
        private string drink;
        private string souvenir;

        public CreatePremiumTicket(string drink, string souvenir)
        {
            this.drink = drink;
            this.souvenir = souvenir;
        }

        public Ticket CreateTicket()
        {
            return new PremiumTicket
            {
                Drink = drink,
                Souvenir=souvenir
            };

        }
    }
}
