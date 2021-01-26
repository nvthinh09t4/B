using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_TienVaCacKhoanTuongDuongTien : BaseEntity
    {
        public float TongCong { get; set; }
        public float Tien { get; set; }
        public float CacKhoanTuongDuongTien { get; set; }
        public long RPAB_TaiSanNganHanId { get; set; }
        public virtual RPAB_TaiSanNganHan ParentRecord { get; set; }
    }
}
