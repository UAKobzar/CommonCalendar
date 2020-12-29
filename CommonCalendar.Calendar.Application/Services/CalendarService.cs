using CommonCalendar.Calendar.Application.Interfaces;
using CommonCalendar.Calendar.Application.Models;
using CommonCalendar.Calendar.Domain.Commands;
using CommonCalendar.Calendar.Domain.Interfaces;
using CommonCalendar.Calendar.Domain.Models;
using CommonCalendar.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCalendar.Calendar.Application.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly ICalendarRepository _calendarRepository;
        private readonly IEventBus _bus;
        public CalendarService(
            ICalendarRepository calendarRepository,
            IEventBus bus)
        {
            _calendarRepository = calendarRepository;
            _bus = bus;
        }

        public async void CreateCalendarEvent(CalendarEventDTO calendarEvent)
        {
            var createCalendarEventCommand = new CreateCalendarEventCommand(calendarEvent.Description);

           await _bus.SendCommand(createCalendarEventCommand);
        }

        public IEnumerable<CalendarEvent> GetCalendarEvents()
        {
           return  _calendarRepository.GetAllCalendarEvents();
        }
    }
}
