using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_TaiSanDaiHan : BaseEntity
    {
        public string Code { get; set; }

        public long StockReportAccountingBalanceId { get; set; }
        public virtual StockReportAccountingBalance ParentReport { get; set; }

        public Criteria_CacKhoanPhaiThuDaiHan CacKhoanPhaiThuDaiHan { get; set; } = new Criteria_CacKhoanPhaiThuDaiHan();
        public Criteria_TaiSanCoDinh TaiSanCoDinh { get; set; } = new Criteria_TaiSanCoDinh();
        public Criteria_BatDongSanDauTu BatDongSanDauTu { get; set; } = new Criteria_BatDongSanDauTu();
        public Criteria_TaiSanDoDangDaiHan TaiSanDoDangDaiHan { get; set; } = new Criteria_TaiSanDoDangDaiHan();
        public Criteria_CacKhoanDauTuTaiChinhDaiHan CacKhoanDauTuTaiChinhDaiHan { get; set; } = new Criteria_CacKhoanDauTuTaiChinhDaiHan();
        public Criteria_TaiSanDaiHanKhac TaiSanDaiHanKhac { get; set; } = new Criteria_TaiSanDaiHanKhac();
        public Criteria_LoiTheThuongMaiTruoc2015 LoiTheThuongMaiTruoc2015 { get; set; } = new Criteria_LoiTheThuongMaiTruoc2015();

        public float TongCong { get; set; }

    }
}
