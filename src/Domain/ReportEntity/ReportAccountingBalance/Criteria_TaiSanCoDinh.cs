using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_TaiSanCoDinh : BaseEntity
    {
        public float TongCong { get; set; }

        public float TaiSanCoDinhHuuHinh { get; set; }
        public float TaiSanCoDinhThueTaiChinh { get; set; }
        public float TaiSanCoDinhVoHinh { get; set; }
        public float ChiPhiXayDungCoBanDoDang { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
