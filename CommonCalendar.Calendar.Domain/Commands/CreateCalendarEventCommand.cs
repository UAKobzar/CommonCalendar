using CommonCalendar.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCalendar.Calendar.Domain.Commands
{
    public class CreateCalendarEventCommand : Command
    {
        public CreateCalendarEventCommand(string description)
        {
            Description = description;
        }
        public string Description { get; set; }
    }
}
