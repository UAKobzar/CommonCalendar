using CommonCalendar.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCalendar.Calendar.Domain.Events
{
    public class CalendarEventAddedEvent : Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
