using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.Abstractions.Services.Concrete;
using Eventify_Tutorial_Series.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<ITextService, TextService>();
        }
    }
}
