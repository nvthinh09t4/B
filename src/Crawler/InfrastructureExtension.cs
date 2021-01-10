using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crawler
{
    public static class InfrastructureExtension
    {
        public static void AddCrawlerInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStockCrawler, StockCrawler>();
        }
    }
}
