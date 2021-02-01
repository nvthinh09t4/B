using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_TaiSanDaiHan : BaseEntity
    {
        public Criteria_CacKhoanPhaiThuDaiHan CacKhoanPhaiThuDaiHan { get; set; }
        public Criteria_TaiSanCoDinh TaiSanCoDinh { get; set; }
        public Criteria_BatDongSanDauTu BatDongSanDauTu { get; set; } 
        public Criteria_TaiSanDoDangDaiHan TaiSanDoDangDaiHan { get; set; }
        public Criteria_CacKhoanDauTuTaiChinhDaiHan CacKhoanDauTuTaiChinhDaiHan { get; set; }
        public Criteria_TaiSanDaiHanKhac TaiSanDaiHanKhac { get; set; } 
        public Criteria_LoiTheThuongMaiTruoc2015 LoiTheThuongMaiTruoc2015 { get; set; }

        public float TongCong { get; set; }

    }
}
