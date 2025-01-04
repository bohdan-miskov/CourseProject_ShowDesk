namespace CourseProject_ShowDesk.FactoryMethod
{
    public class CreateStandardTicket : ICreateTicket
    {
        public StandardTicket CreateTicket()
        {
            return new StandardTicket();
        }
    }
}
