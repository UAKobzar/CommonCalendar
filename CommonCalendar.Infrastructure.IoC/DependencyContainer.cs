using MediatR;
using CommonCalendar.Domain.Core.Bus;
using CommonCalendar.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using CommonCalendar.Calendar.Application.Interfaces;
using CommonCalendar.Calendar.Application.Services;
using CommonCalendar.Calendar.Domain.Interfaces;
using CommonCalendar.Calendar.Data.Repository;
using CommonCalendar.Calendar.Domain.Commands;
using CommonCalendar.Calendar.Domain.CommandHandlers;

namespace CommonCalendar.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // EventBus

            services.AddTransient<IEventBus, RabbitMQBus>();

            //Calendar Domain Handlers

            services.AddTransient<IRequestHandler<CreateCalendarEventCommand, bool>, CreateCalendarEventCommandHandler>();

            //Calendar

            services.AddTransient<ICalendarService, CalendarService>();
            services.AddSingleton<ICalendarRepository, InMemoryCalendarRepository>();
        }
    }
}
