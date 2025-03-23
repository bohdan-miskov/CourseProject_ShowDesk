using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket
{
    public class CreatePremiumTicket : ICreateTicket
    {
        private readonly string drink;
        private readonly string souvenir;

        public CreatePremiumTicket(string drink, string souvenir)
        {
            this.drink = drink;
            this.souvenir = souvenir;
        }

        public StandardTicket CreateTicket()
        {
            return new PremiumTicket
            {
                Type="Premium",
                Drink = drink,
                Souvenir = souvenir
            };

        }
    }
}
