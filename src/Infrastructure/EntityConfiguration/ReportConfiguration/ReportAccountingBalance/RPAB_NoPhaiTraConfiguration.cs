using Domain.ReportEntity;
using Domain.ReportEntity.ReportAccountingBalance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration.ReportConfiguration.ReportAccountingBalance
{
    public class RPAB_NoPhaiTraConfiguration : IEntityTypeConfiguration<RPAB_NoPhaiTra>
    {
        public void Configure(EntityTypeBuilder<RPAB_NoPhaiTra> builder)
        {
            builder.HasOne(x => x.NoDaiHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_NoDaiHan>(y => y.RPAB_NoPhaiTraId);
            builder.HasOne(x => x.NoNganHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_NoNganHan>(y => y.RPAB_NoPhaiTraId);
            
        }
    }
}
