using CourseProject_ShowDesk.Scripts.Utilities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities
{
    [Serializable]
    public class Performance
    {
        [BsonIgnore]
        private PerformanceBaseService performanceBaseService;
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string name;
        private double price;
        private DateTime performanceDateTime;
        private List<int> availablePositions;
        private TimeSpan duration;
        private Guid stageId;
        private List<StandardTicket> tickets;

        //public Performance()
        //{
        //    name = "";
        //    price = 0.0;
        //    performanceDateTime = DateTime.Now;
        //    duration=TimeSpan.MinValue;
        //    stageIndex = -1;
        //    tickets = new List<StandardTicket>();
        //}
        public Performance(PerformanceBaseService performanceBaseService)
        {
            this.performanceBaseService = performanceBaseService;
            tickets = new List<StandardTicket>();
        }
        public Performance(string name, double price, DateTime performanceDateTime,TimeSpan duration, Guid stageId, List<int> availablePositions)
        {
            Name = name;
            Price = price;
            PerformanceDateTime = performanceDateTime;
            Duration = duration;
            StageId = stageId;
            tickets = new List<StandardTicket>();
            this.availablePositions = availablePositions;
        }
        public Guid Id
        {
            get
            {
                return id;
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

        public Guid StageId
        {
            get
            {
                return stageId;
            }
            set
            {
                stageId = value;
            }
        }
        public List<int> AvailablePositions
        {
            get
            {
                return availablePositions;
            }
            set
            {
                availablePositions = value;
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
                tickets = value ?? throw new ArgumentNullException(nameof(Tickets), "Tickets list cannot be null.");
            }
        }

        public void BuyTicket(StandardTicket newTicket)
        {
            if (newTicket == null)
            {
                throw new ArgumentNullException(nameof(newTicket), "Ticket cannot be null.");
            }
            if (!availablePositions.Contains(newTicket.Position))
            {
                throw new ArgumentNullException(nameof(newTicket), "Current position sold");
            }
            availablePositions.Remove(newTicket.Position);
            tickets.Add(newTicket);
            performanceBaseService = new PerformanceBaseService();
            performanceBaseService.RemovePosition(this.id, newTicket.Position);
            performanceBaseService.AddTicket(this.id, newTicket);

        }

        public void ChangeTicketStatus(Guid ticketId)
        {
            var existingTicket = tickets.FirstOrDefault(s => s.Id == ticketId);
            if (existingTicket != null)
            {
                int index = tickets.IndexOf(existingTicket);
                tickets[index].ChangeStatus();
                performanceBaseService.UpdateTicket(this.id, tickets[index]);
            }
        }

        public void RemoveTicket(Guid ticketId)
        {
            StandardTicket ticket = tickets.FirstOrDefault(p => p.Id == ticketId);
            if (ticket != null)
            {
                tickets.Remove(ticket);
                availablePositions.Add(ticket.Position);
                availablePositions.Sort();
                performanceBaseService.RemoveTicket(this.id, ticketId);
                performanceBaseService.AddPosition(this.id, ticket.Position);
            }
        }

        //public void RemoveAllTickets()
        //{
        //    tickets.Clear();
        //}

        public StandardTicket GetTicketById(Guid id)
        {
            return tickets.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateTicket(StandardTicket updatedTicket)
        {
            var existingTicket = tickets.FirstOrDefault(s => s.Id == updatedTicket.Id);
            if (existingTicket != null)
            {
                int index = tickets.IndexOf(existingTicket);
                tickets[index] = updatedTicket;
                performanceBaseService.UpdateTicket(this.id, updatedTicket);
            }
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
