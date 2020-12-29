using MediatR;
using CommonCalendar.Domain.Core.Bus;
using CommonCalendar.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCalendar.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // EventBus

            services.AddTransient<IEventBus, RabbitMQBus>();

            //Calendar

            services.AddTransient<ICa>
        }
    }
}
