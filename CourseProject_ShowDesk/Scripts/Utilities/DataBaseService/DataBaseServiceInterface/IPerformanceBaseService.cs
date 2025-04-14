using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using System;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService.DataBaseServiceInterface
{
    public interface IPerformanceBaseService
    {
        void RemovePosition(Guid performanceId, int position);
        void AddTicket(Guid performanceId, StandardTicket ticket);
        void UpdateTicket(Guid performanceId, StandardTicket ticket);
        void RemoveTicket(Guid performanceId, Guid ticketId);
        void AddPosition(Guid performanceId, int position);
    }

}
