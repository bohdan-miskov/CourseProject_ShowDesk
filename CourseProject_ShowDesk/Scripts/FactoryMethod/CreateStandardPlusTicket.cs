using CourseProject_ShowDesk.Scripts;

namespace CourseProject_ShowDesk.FactoryMethod
{
    public class CreateStandardPlusTicket : ICreateTicket
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
