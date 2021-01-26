using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015 : BaseEntity
    {
        public long StockReportAccountingBalanceId { get; set; }
        public StockReportAccountingBalance StockReportAccountingBalanceReport { get; set; }

        public float TongCong { get; set; }
    }
}
