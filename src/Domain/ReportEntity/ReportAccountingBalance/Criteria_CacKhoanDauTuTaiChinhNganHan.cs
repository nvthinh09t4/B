using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_CacKhoanDauTuTaiChinhNganHan : BaseEntity
    {
        public float TongCong { get; set; }
        public float DauTuNganHan { get; set; }
        public float DuPhongGiamGiaDauTuNganHan { get; set; }
        public float DauTuGiuDenNgayDaoHan { get; set; }
        public long RPAB_TaiSanNganHanId { get; set; }
        public virtual RPAB_TaiSanNganHan ParentRecord { get; set; }
    }
}
