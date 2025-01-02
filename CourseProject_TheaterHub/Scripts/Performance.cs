using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub
{
    [Serializable]
    public class Performance
    {
        private DateTime performanceDateTime;
        private string name;       
        private double basePrice;       
        private int stageIndex;          
        private List<Ticket> tickets;   

        public Performance()
        {
            performanceDateTime = DateTime.Now;
            name = "";
            basePrice = 0.0;
            stageIndex = -1;
            tickets = new List<Ticket>();
        }
        public Performance(DateTime performanceDateTime, string name, double basePrice, int stageIndex)
        {
            this.performanceDateTime = performanceDateTime;
            this.name = name;
            this.basePrice = basePrice;
            this.stageIndex = stageIndex;
            this.tickets = new List<Ticket>();
        }

        public DateTime PerformanceDateTime
        {
            get
            {
                return performanceDateTime;
            }
            set
            {
                performanceDateTime = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value.Length > 0) ? value : "Undefined";
            }
        }
        public double Price
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = (value < 0) ? 0 : value;
            }
        }
        public int StageIndex
        {
            get
            {
                return stageIndex;
            }
            set
            {
                stageIndex = (value < 0) ? -1 : value;
            }
        }
        public List<Ticket> Tickets
        {
            get
            {
                return tickets;
            }
            set
            {
                tickets = value;
            }
        }

        public void BuyTicket(Ticket newTicket)
        {
            tickets.Add(newTicket);
        }

        public void ChangeTicketStatus(int ticketIndex)
        {
            tickets[ticketIndex].ChangeStatus();
        }

        public void RemoveTicket(int ticketIndex)
        {
            tickets.RemoveAt(ticketIndex);
        }

        public void RemoveAllTickets()
        {
            tickets.Clear();
        }

        public double GetRevenue()
        {
            double revenue = 0.0;

            foreach (Ticket ticket in tickets)
            {
                revenue += ticket.CalculatedPrice;
            }

            return revenue;
        }
    }
}
