using Domain.ReportEntity;
using Domain.ReportEntity.ReportAccountingBalance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration.ReportConfiguration.ReportAccountingBalance
{
    public class RPAB_VonChuSoHuuConfiguration : IEntityTypeConfiguration<RPAB_VonChuSoHuu>
    {
        public void Configure(EntityTypeBuilder<RPAB_VonChuSoHuu> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.VonVaCacQuy)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_VonVaCacQuy>(y => y.RPAB_VonChuSoHuuId);
            builder.HasOne(x => x.NguonKinhPhiVanQuyKhac)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_NguonKinhPhiVanQuyKhac>(y => y.RPAB_VonChuSoHuuId);
            
        }
    }
}
