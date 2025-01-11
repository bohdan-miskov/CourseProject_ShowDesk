using System;
using System.Collections.Generic;
using System.Web.UI;

namespace CourseProject_ShowDesk
{
    [Serializable]
    public class Performance
    {
        private string name;
        private double price;
        private DateTime performanceDateTime;
        private TimeSpan duration;
        private int stageIndex;
        private List<StandardTicket> tickets;

        public Performance()
        {
            name = "";
            price = 0.0;
            performanceDateTime = DateTime.Now;
            duration=TimeSpan.MinValue;
            stageIndex = -1;
            tickets = new List<StandardTicket>();
        }
        public Performance(string name, double price, DateTime performanceDateTime,TimeSpan duration, int stageIndex)
        {
            Name = name;
            Price = price;
            PerformanceDateTime = performanceDateTime;
            Duration = duration;
            StageIndex = stageIndex;
            tickets = new List<StandardTicket>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Performance name cannot be empty or whitespace.", nameof(Name));
                }
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "Price cannot be negative.");
                }
                price = value;
            }
        }

        public DateTime PerformanceDateTime
        {
            get
            {
                return performanceDateTime;
            }
            set
            {
                if (value < DateTime.Now.AddYears(-1) && value > DateTime.Now.AddYears(1))
                {
                    throw new ArgumentException("The date of the performance cannot be later or erlier than a year later.");
                }

                performanceDateTime = value;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new ArgumentException("Duration cannot be negative.");
                }

                duration = value;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(StageIndex), "Stage index cannot be negative.");
                }
                stageIndex = value;
            }
        }
        public List<StandardTicket> Tickets
        {
            get
            {
                return tickets;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Tickets), "Tickets list cannot be null.");
                }
                tickets = value;
            }
        }

        public void BuyTicket(StandardTicket newTicket)
        {
            if (newTicket == null)
            {
                throw new ArgumentNullException(nameof(newTicket), "Ticket cannot be null.");
            }
            tickets.Add(newTicket);
        }

        public void ChangeTicketStatus(int ticketIndex)
        {
            if (ticketIndex < 0 || ticketIndex >= tickets.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(ticketIndex), "Ticket index is out of range.");
            }
            tickets[ticketIndex].ChangeStatus();
        }

        public void RemoveTicket(int ticketIndex)
        {
            if (ticketIndex < 0 || ticketIndex >= tickets.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(ticketIndex), "Ticket index is out of range.");
            }
            tickets.RemoveAt(ticketIndex);
        }

        public void RemoveAllTickets()
        {
            tickets.Clear();
        }

        public double GetRevenue()
        {
            double revenue = 0.0;

            foreach (StandardTicket ticket in tickets)
            {
                revenue += ticket.CalculatedPrice;
            }

            return revenue;
        }
    }
}
