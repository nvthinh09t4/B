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
        public Criteria_NoDaiHan NoDaiHan { get; set; } 
        public Criteria_NoNganHan NoNganHan { get; set; }

        public float TongCong { get; set; }

    }
}
