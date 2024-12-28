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
        private DateTime performanceDate;   
        private string name;       
        private double basePrice;       
        private int stageIndex;          
        private List<Ticket> tickets;   

        public Performance()
        {
            performanceDate = DateTime.Now;
            name = "";
            basePrice = 0.0;
            stageIndex = -1;
            tickets = new List<Ticket>();
        }
        public Performance(DateTime performanceDate, string name, double basePrice, int stageIndex)
        {
            this.performanceDate = performanceDate;
            this.name = name;
            this.basePrice = basePrice;
            this.stageIndex = stageIndex;
            this.tickets = new List<Ticket>();
        }

        public DateTime PerformanceDate
        {
            get
            {
                return performanceDate;
            }
            set
            {
                performanceDate = value;
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

        public object Clone()
        {
            List<Ticket> tickets = new List<Ticket>(this.Tickets);
            return new Performance
            {
                PerformanceDate = this.PerformanceDate,
                Name = this.Name,
                Price = this.Price,
                StageIndex = this.StageIndex,
                Tickets = tickets
            };
        }
    }


}
