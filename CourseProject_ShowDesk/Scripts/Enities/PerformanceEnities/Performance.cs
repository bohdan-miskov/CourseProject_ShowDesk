using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService.DataBaseServiceInterface;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities
{
    [Serializable]
    public class Performance
    {
        [BsonIgnore]
        private IPerformanceBaseService performanceBaseService;
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string name;
        private double price;
        private DateTime performanceDateTime;
        private List<int> availablePositions;
        private TimeSpan duration;
        private Guid stageId;
        private List<StandardTicket> tickets;

        public Performance()
        {
            tickets = new List<StandardTicket>();
        }
        public Performance(string name, double price, DateTime performanceDateTime, TimeSpan duration, Guid stageId, List<int> availablePositions)
        {
            Name = name;
            Price = price;
            LocalPerformanceDateTime = performanceDateTime;
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
                if (value < 0 && value != double.NaN)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "Price cannot be negative.");
                }
                price = value;
            }
        }

        public DateTime PerformanceDateTime
        {
            set
            {
                performanceDateTime = value.ToLocalTime();
            }
            get
            {
                return performanceDateTime;
            }
        }

        [BsonIgnore]
        public DateTime LocalPerformanceDateTime
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

        public void InitializeService(IPerformanceBaseService performanceBaseService)
        {
            this.performanceBaseService = performanceBaseService ?? throw new ArgumentNullException(nameof(performanceBaseService));
        }

        public async Task BuyTicketAsync(StandardTicket newTicket)
        {
            if (newTicket == null)
            {
                throw new ArgumentNullException(nameof(newTicket), "Ticket cannot be null.");
            }
            if (!availablePositions.Contains(newTicket.Position))
            {
                throw new InvalidOperationException("Current position sold");
            }
            availablePositions.Remove(newTicket.Position);
            tickets.Add(newTicket);
            await performanceBaseService.RemovePositionAsync(this.id, newTicket.Position);
            await performanceBaseService.AddTicketAsync(this.id, newTicket);

        }

        public async Task ChangeTicketStatusAsync(Guid ticketId)
        {
            var existingTicket = tickets.FirstOrDefault(s => s.Id == ticketId);
            if (existingTicket != null)
            {
                int index = tickets.IndexOf(existingTicket);
                tickets[index].ChangeStatus();
                await performanceBaseService.UpdateTicketAsync(this.id, tickets[index]);
            }
        }

        public async Task RemoveTicketAsync(Guid ticketId)
        {
            StandardTicket ticket = tickets.FirstOrDefault(p => p.Id == ticketId);
            if (ticket != null)
            {
                tickets.Remove(ticket);
                availablePositions.Add(ticket.Position);
                availablePositions.Sort();
                await performanceBaseService.RemoveTicketAsync(this.id, ticketId);
                await performanceBaseService.AddPositionAsync(this.id, ticket.Position);
            }
        }

        public void RemoveAllTickets()
        {
            tickets.Clear();
        }

        public StandardTicket GetTicketById(Guid id)
        {
            return tickets.FirstOrDefault(s => s.Id == id);
        }

        public async Task UpdateTicketAsync(StandardTicket updatedTicket)
        {
            var existingTicket = tickets.FirstOrDefault(s => s.Id == updatedTicket.Id);
            if (existingTicket != null)
            {
                int index = tickets.IndexOf(existingTicket);
                tickets[index] = updatedTicket;
                await performanceBaseService.UpdateTicketAsync(this.id, updatedTicket);
            }
        }

        public int GetCountSoldTickets()
        {
            int counter = 0;
            foreach (StandardTicket ticket in tickets)
            {
                if (!ticket.Reserved) counter++;
            }
            return counter;
        }

        public int GetCountReservedTickets()
        {
            int counter = 0;
            foreach (StandardTicket ticket in tickets)
            {
                if (ticket.Reserved)
                {
                    counter++;
                }
            }
            return counter;
        }

        public double GetRevenue()
        {
            double revenue = 0.0;

            foreach (StandardTicket ticket in tickets)
            {
                if(!ticket.Reserved)
                    revenue += ticket.CalculatedPrice;
            }

            return revenue;
        }

        public bool IsAvailable(int position)
        {
            if (availablePositions.Contains(position)) return true;
            return false;
        }
    }
}
