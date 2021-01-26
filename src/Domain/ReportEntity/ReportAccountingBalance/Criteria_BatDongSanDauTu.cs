using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_BatDongSanDauTu : BaseEntity
    {
        public float TongCong { get; set; }

        public float NguyenGiaBatDongSanDauTu { get; set; }
        public float HaoMonBatDongSanDauTu { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
