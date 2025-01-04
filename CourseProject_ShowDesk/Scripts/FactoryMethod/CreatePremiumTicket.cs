using CourseProject_ShowDesk.Scripts;

namespace CourseProject_ShowDesk.FactoryMethod
{
    public class CreatePremiumTicket : ICreateTicket
    {
        private string drink;
        private string souvenir;

        public CreatePremiumTicket(string drink, string souvenir)
        {
            this.drink = drink;
            this.souvenir = souvenir;
        }

        public StandardTicket CreateTicket()
        {
            return new PremiumTicket
            {
                Drink = drink,
                Souvenir = souvenir
            };

        }
    }
}
