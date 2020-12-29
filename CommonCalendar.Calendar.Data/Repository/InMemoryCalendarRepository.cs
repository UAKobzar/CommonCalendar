using CommonCalendar.Calendar.Domain.Interfaces;
using CommonCalendar.Calendar.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonCalendar.Calendar.Data.Repository
{
    class InMemoryCalendarRepository : ICalendarRepository
    {
        private List<CalendarEvent> _events;

        public InMemoryCalendarRepository()
        {
            _events = new List<CalendarEvent>();
        }

        public Task<CalendarEvent> AddEvent(CalendarEvent calendarEvent)
        {
            calendarEvent.Id = _events.Count + 1;

            _events.Add(calendarEvent);

            return Task.FromResult(calendarEvent);
        }

        public IEnumerable<CalendarEvent> GetAllCalendarEvents()
        {
            return _events;
        }
    }
}
