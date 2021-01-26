using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_TaiSanDaiHanKhac : BaseEntity
    {
        public float TongCong { get; set; }

        public float ChiPhiTraTruocDaiHan { get; set; }
        public float TaiSanThueThuNhapHoanLai { get; set; }
        public float ThietBiVatTuPhuTungThayTheDaiHan { get; set; }
        public float TaiSanDaiHanKhac { get; set; }
        public float LoiTheThuongMai { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
