using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_NoPhaiTra : BaseEntity
    {
        public long StockReportAccountingBalanceId { get; set; }
        public StockReportAccountingBalance StockReportAccountingBalanceReport { get; set; }

        public Criteria_NoDaiHan NoDaiHan { get; set; } = new Criteria_NoDaiHan();
        public Criteria_NoNganHan NoNganHan { get; set; } = new Criteria_NoNganHan();

        public float TongCong { get; set; }

    }
}
