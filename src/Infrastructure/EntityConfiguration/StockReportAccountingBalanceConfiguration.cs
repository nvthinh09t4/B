﻿using Domain;
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
            builder.HasOne(x => x.CriteriaTaiSanNganHan).WithOne(y => y.ParentReport).HasForeignKey<RPAB_TaiSanNganHan>(y => y.StockReportAccountingBalanceId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.CriteriaTaiSanDaiHan).WithOne(y => y.ParentReport).HasForeignKey<RPAB_TaiSanDaiHan>(y => y.StockReportAccountingBalanceId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.CriteriaNoPhaiTra).WithOne(y => y.ParentReport).HasForeignKey<RPAB_NoPhaiTra>(y => y.StockReportAccountingBalanceId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.CriteriaVonChuSuHuu).WithOne(y => y.ParentReport).HasForeignKey<RPAB_VonChuSoHuu>(y => y.StockReportAccountingBalanceId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015).WithOne(y => y.ParentReport).HasForeignKey<RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015>(y => y.StockReportAccountingBalanceId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
