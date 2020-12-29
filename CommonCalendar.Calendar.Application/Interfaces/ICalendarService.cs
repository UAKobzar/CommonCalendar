using CommonCalendar.Calendar.Application.Models;
using CommonCalendar.Calendar.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCalendar.Calendar.Application.Interfaces
{
    public interface ICalendarService
    {
        IEnumerable<CalendarEvent> GetCalendarEvents();

        void CreateCalendarEvent(CalendarEventDTO calendarEvent);
    }
}
