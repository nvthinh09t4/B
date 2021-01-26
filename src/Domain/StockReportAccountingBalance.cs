using Domain.Common;
using Domain.ReportEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockReportAccountingBalance : BaseEntity
    {
        public string Year { get; set; }
        public string Quarter { get; set; }
        public string Code { get; set; }

        public RPAB_TaiSanNganHan CriteriaTaiSanNganHan { get; set; } = new RPAB_TaiSanNganHan();
        public RPAB_TaiSanDaiHan CriteriaTaiSanDaiHan { get; set; } = new RPAB_TaiSanDaiHan();
        public RPAB_NoPhaiTra CriteriaNoPhaiTra { get; set; } = new RPAB_NoPhaiTra();
        public RPAB_VonChuSoHuu CriteriaVonChuSuHuu { get; set; } = new RPAB_VonChuSoHuu();
        public RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015 CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015 { get; set; } = new RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015();


        public float TongCongTaiSan { get; set; }
        public float TongCongNguonVon { get; set; }
    }
}
