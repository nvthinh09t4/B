using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_CacKhoanDauTuTaiChinhDaiHan : BaseEntity
    {
        public float TongCong { get; set; }

        public float DauTuVaoCongTyCon { get; set; }
        public float DauTuVaoCongTyLienKetLienDoanh { get; set; }
        public float DauTuDaiHanKhac { get; set; }
        public float DuPhongGiamGiaDauTuTaiChinhDaiHan { get; set; }
        public float DauTuDaiHanGiuDenNgayDaoHan { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
