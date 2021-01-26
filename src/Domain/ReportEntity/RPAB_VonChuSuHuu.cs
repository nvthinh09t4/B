using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_VonChuSoHuu : BaseEntity
    {
        public long StockReportAccountingBalanceId { get; set; }
        public StockReportAccountingBalance StockReportAccountingBalanceReport { get; set; }

        public Criteria_VonVaCacQuy VonVaCacQuy { get; set; } = new Criteria_VonVaCacQuy();
        public Criteria_NguonKinhPhiVanQuyKhac NguonKinhPhiVanQuyKhac { get; set; } = new Criteria_NguonKinhPhiVanQuyKhac();

        public float TongCong { get; set; }
    }
}
