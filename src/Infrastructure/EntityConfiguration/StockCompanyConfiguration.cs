using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class StockCompanyConfiguration : IEntityTypeConfiguration<StockCompany>
    {
        public void Configure(EntityTypeBuilder<StockCompany> builder)
        {
            builder.HasMany(stockCompany => stockCompany.Leaderships).WithOne(stockCompanyLeadership => stockCompanyLeadership.Company);
            builder.HasMany(stockCompany => stockCompany.MainShareholder).WithOne(mainShareHolder => mainShareHolder.Company);
            builder.HasMany(stockCompany => stockCompany.ForeignerHolderRates).WithOne(foreignerHolderRates => foreignerHolderRates.Company);
        }
    }
}
