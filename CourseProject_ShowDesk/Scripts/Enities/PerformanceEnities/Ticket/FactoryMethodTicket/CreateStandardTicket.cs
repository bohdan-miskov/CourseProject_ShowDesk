namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket.FactoryMethodTicket
{
    public class CreateStandardTicket : ICreateTicket
    {
        public StandardTicket CreateTicket()
        {
            return new StandardTicket()
            {
                Type = "Standard"
            };
        }
    }
}