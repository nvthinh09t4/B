using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_HangTonKho : BaseEntity
    {
        public float TongCong { get; set; }

        public float HangTonKho { get; set; }
        public float DuPhongGiamGiaHangTonKho { get; set; }

        public long RPAB_TaiSanNganHanId { get; set; }
        public virtual RPAB_TaiSanNganHan ParentRecord { get; set; }
    }
}
