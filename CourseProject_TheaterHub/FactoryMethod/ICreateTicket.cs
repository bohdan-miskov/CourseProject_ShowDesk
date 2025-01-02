using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub.FactoryMethod
{
    public interface ICreateTicket
    {
        Ticket CreateTicket();
    }
}
