using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using System;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService.DataBaseServiceInterface
{
    public interface IPerformanceBaseService
    {
        Task RemovePositionAsync(Guid performanceId, int position);
        Task AddTicketAsync(Guid performanceId, StandardTicket ticket);
        Task UpdateTicketAsync(Guid performanceId, StandardTicket ticket);
        Task RemoveTicketAsync(Guid performanceId, Guid ticketId);
        Task AddPositionAsync(Guid performanceId, int position);
    }

}
