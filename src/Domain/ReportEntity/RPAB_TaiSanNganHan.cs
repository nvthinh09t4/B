using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_TaiSanNganHan : BaseEntity
    {
        public Criteria_TienVaCacKhoanTuongDuongTien TienVaCacKhoanTuongDuongTien { get; set; } = new Criteria_TienVaCacKhoanTuongDuongTien();
        public Criteria_CacKhoanDauTuTaiChinhNganHan CacKhoanDauTuTaiChinhNganHan { get; set; } = new Criteria_CacKhoanDauTuTaiChinhNganHan();
        public Criteria_CacKhoanPhaiThuNganHan CacKhoanPhaiThuNganHan { get; set; } = new Criteria_CacKhoanPhaiThuNganHan();
        public Criteria_HangTonKho HangTonKho { get; set; } = new Criteria_HangTonKho();
        public Criteria_TaiSanNganHanKhac TaiSanNganHanKhac { get; set; } = new Criteria_TaiSanNganHanKhac();

        public float TongCong { get; set; }

    }
}
