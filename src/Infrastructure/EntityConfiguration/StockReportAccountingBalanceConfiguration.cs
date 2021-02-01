using Domain;
using Domain.ReportEntity;
using Domain.ReportEntity.ReportAccountingBalance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class StockReportAccountingBalanceConfiguration : IEntityTypeConfiguration<StockReportAccountingBalance>
    {
        public void Configure(EntityTypeBuilder<StockReportAccountingBalance> builder)
        {
            builder.HasOne(x => x.CriteriaTaiSanNganHan);
            builder.HasOne(x => x.CriteriaTaiSanDaiHan);
            builder.HasOne(x => x.CriteriaNoPhaiTra);
            builder.HasOne(x => x.CriteriaVonChuSuHuu);
            builder.HasOne(x => x.CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015);
        }
    }
}
