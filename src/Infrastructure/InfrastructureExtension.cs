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
            services.AddScoped<IFileCategoryRepository, FileCategoryRepository>();
            services.AddScoped<ICategoryTypeRepository, CategoryTypeRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IVisitorRepository, VisitorRepository>();
            services.AddScoped<INewspaperRepository, NewspaperRepository>();
            services.AddScoped<INewspaperSubCategoryRepository, NewspaperSubCategoryRepository>();
            services.AddScoped<INewspaperUserSubcribeRepository, NewspaperUserSubcribeRepository>();
            services.AddScoped<IStockIndexRepository, StockIndexRepository>();
            services.AddScoped<IStockGroupRepository, StockGroupRepository>();
            services.AddScoped<IStockMainInformationRepository, StockMainInformationRepository>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddScoped<IStockCompanyRepository, StockCompanyRepository>();
            services.AddScoped<IStockCompanyLeadershipRepository, StockCompanyLeadershipRepository>();
            services.AddScoped<IStockForeignerHolderRateRepository, StockForeignerHolderRateRepository>();
            services.AddScoped<IStockShareholderRepository, StockShareholderRepository>();
            services.AddScoped<IStockReportAccountingBalanceRepository, StockReportAccountingBalanceRepository>();
        }
    }
}
