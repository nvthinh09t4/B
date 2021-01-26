using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_TaiSanDoDangDaiHan : BaseEntity
    {
        public float TongCong { get; set; }

        public float ChiPhiSanXuatKinhDoanhDoDangDaiHan { get; set; }
        public float ChiPhiXayDungCoBanDoDang { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
