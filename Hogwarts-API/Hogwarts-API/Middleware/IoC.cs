using Hogwart.Repository;
using Hogwart.Repository.Interfaces;
using Hogwarts.Application;
using Hogwarts.Application.Interfaces;
using Hogwarts.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Hogwarts_API.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services) 
        {
            services.AddTransient<IApplicationAdmisionRepository, ApplicationAdmisionRepository>();
            services.AddTransient<IApplicationAdmisionService, ApplicationAdmisionService>();
            services.AddTransient<IApplicationAdmisionApplication, ApplicationAdmisionApplication>();

            return services;
        }
    }
}
