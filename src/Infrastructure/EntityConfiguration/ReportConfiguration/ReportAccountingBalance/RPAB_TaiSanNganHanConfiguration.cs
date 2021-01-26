using Domain.ReportEntity;
using Domain.ReportEntity.ReportAccountingBalance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration.ReportConfiguration.ReportAccountingBalance
{
    public class RPAB_TaiSanNganHanConfiguration : IEntityTypeConfiguration<RPAB_TaiSanNganHan>
    {
        public void Configure(EntityTypeBuilder<RPAB_TaiSanNganHan> builder)
        {
            builder.HasOne(x => x.TienVaCacKhoanTuongDuongTien)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_TienVaCacKhoanTuongDuongTien>(y => y.RPAB_TaiSanNganHanId);
            builder.HasOne(x => x.CacKhoanDauTuTaiChinhNganHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_CacKhoanDauTuTaiChinhNganHan>(y => y.RPAB_TaiSanNganHanId);
            builder.HasOne(x => x.CacKhoanPhaiThuNganHan)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_CacKhoanPhaiThuNganHan>(y => y.RPAB_TaiSanNganHanId);
            builder.HasOne(x => x.HangTonKho)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_HangTonKho>(y => y.RPAB_TaiSanNganHanId);
            builder.HasOne(x => x.TaiSanNganHanKhac)
                .WithOne(y => y.ParentRecord)
                .HasForeignKey<Criteria_TaiSanNganHanKhac>(y => y.RPAB_TaiSanNganHanId);
        }
    }
}
