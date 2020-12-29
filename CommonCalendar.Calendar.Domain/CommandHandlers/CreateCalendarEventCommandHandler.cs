using CommonCalendar.Calendar.Domain.Commands;
using CommonCalendar.Calendar.Domain.Events;
using CommonCalendar.Calendar.Domain.Interfaces;
using CommonCalendar.Domain.Core.Bus;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonCalendar.Calendar.Domain.CommandHandlers
{
    public class CreateCalendarEventCommandHandler : IRequestHandler<CreateCalendarEventCommand, bool>
    {
        private readonly IEventBus _bus;
        ICalendarRepository _calendarRepository;

        public CreateCalendarEventCommandHandler(
            IEventBus bus
            ,ICalendarRepository calendarRepository
            )
        {
            _bus = bus;
            _calendarRepository = calendarRepository;
        }

        public async Task<bool> Handle(CreateCalendarEventCommand request, CancellationToken cancellationToken)
        {
            var model = new Models.CalendarEvent()
            {
                Description = request.Description
            };
            var addedEvent = await _calendarRepository.AddEvent(model);

            var @event = new CalendarEventAddedEvent()
            {
                Description = addedEvent.Description,
                Id = addedEvent.Id
            };

            _bus.Publish(@event);

            return true;
        }
    }
}
