namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket
{
    public class CreateStandardPlusTicket : ICreateTicket
    {
        private readonly string drink;
        public CreateStandardPlusTicket(string drink)
        {
            this.drink = drink;
        }

        public StandardTicket CreateTicket()
        {
            return new StandardPlusTicket
            {
                Type = "StandardPlus",
                Drink = drink
            };
        }
    }
}
