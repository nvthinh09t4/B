using Domain.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public static class InfrastructureExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services) {
            services.AddScoped<IFileStorageRepository, FileStorageRepository>();
        }
    }
}
