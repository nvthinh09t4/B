using Domain.ReportEntity;
using Domain.ReportEntity.ReportAccountingBalance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration.ReportConfiguration.ReportAccountingBalance
{
    public class RPAB_TaiSanDaiHanConfiguration : IEntityTypeConfiguration<RPAB_TaiSanDaiHan>
    {
        public void Configure(EntityTypeBuilder<RPAB_TaiSanDaiHan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.BatDongSanDauTu)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_BatDongSanDauTu>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.CacKhoanDauTuTaiChinhDaiHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_CacKhoanDauTuTaiChinhDaiHan>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.CacKhoanPhaiThuDaiHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_CacKhoanPhaiThuDaiHan>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.TaiSanCoDinh)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_TaiSanCoDinh>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.TaiSanDaiHanKhac)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_TaiSanDaiHanKhac>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.TaiSanDoDangDaiHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_TaiSanDoDangDaiHan>(y => y.RPAB_TaiSanDaiHanId);
            builder.HasOne(x => x.LoiTheThuongMaiTruoc2015)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_LoiTheThuongMaiTruoc2015>(y => y.RPAB_TaiSanDaiHanId);
        }
    }
}
