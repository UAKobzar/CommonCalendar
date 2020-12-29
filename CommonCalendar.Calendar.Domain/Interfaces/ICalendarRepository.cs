using CommonCalendar.Calendar.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonCalendar.Calendar.Domain.Interfaces
{
    public interface ICalendarRepository
    {
        IEnumerable<CalendarEvent> GetAllCalendarEvents();
        Task<CalendarEvent> AddEvent(CalendarEvent calendarEvent);
    }
}
