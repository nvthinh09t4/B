using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_TaiSanNganHanKhac : BaseEntity
    {
        public float TongCong { get; set; }

        public float ChiPhiTraTruocNganHan { get; set; }
        public float ThueGTGTDuocKhauTru { get; set; }
        public float ThueVaCacKhoanKhacPhaiThuNhaNuoc { get; set; }
        public float GiaoDichMuaBanLaiTraiPhieuChinhPhu { get; set; }
        public float TaiSanNganHanKhac { get; set; }

        public long RPAB_TaiSanNganHanId { get; set; }
        public virtual RPAB_TaiSanNganHan ParentRecord { get; set; }
    }
}
