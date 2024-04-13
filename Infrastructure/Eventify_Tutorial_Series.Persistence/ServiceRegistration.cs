using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Persistence.DbContexts;
using Eventify_Tutorial_Series.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
            services.AddDbContext<EventifyDbContext>();
        }
    }
}
