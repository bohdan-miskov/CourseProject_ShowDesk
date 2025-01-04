using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.FactoryMethod
{
    public class CreateStandardTicket:ICreateTicket
    {
        public StandardTicket CreateTicket() 
        { 
            return new StandardTicket(); 
        }
    }
}
