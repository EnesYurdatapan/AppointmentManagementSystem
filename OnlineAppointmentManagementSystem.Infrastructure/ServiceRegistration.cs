﻿using Microsoft.Extensions.DependencyInjection;
using OnlineAppointmentManagementSystem.Application.Abstraction.Token;
using OnlineAppointmentManagementSystem.Infrastructure.Services.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAppointmentManagementSystem.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            serviceCollection.AddScoped<ITokenProvider, TokenProvider>();


        }
    }
}
