using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_NguonKinhPhiVanQuyKhac : BaseEntity
    {
        public float TongCong { get; set; }

        public long RPAB_VonChuSoHuuId { get; set; }
        public virtual RPAB_VonChuSoHuu ParentRecord { get; set; }
    }
}
