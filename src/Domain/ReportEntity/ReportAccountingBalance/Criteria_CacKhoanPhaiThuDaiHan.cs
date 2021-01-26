using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_CacKhoanPhaiThuDaiHan : BaseEntity
    {
        public float TongCong { get; set; }

        public float PhaiThuDaiHanCuaKhachHang { get; set; }
        public float TraTruocDaiHanNguoiBan { get; set; }
        public float VonKinhDoanhODonViTrucThuoc { get; set; }
        public float PhaiThuDaiHanNoiBo { get; set; }
        public float PhaiThuVeChoVayDaiHan { get; set; }
        public float PhaiThuDaiHanKhac { get; set; }
        public float DuPhongPhaiThuDaiHanKhoDoi { get; set; }

        public long RPAB_TaiSanDaiHanId { get; set; }
        public virtual RPAB_TaiSanDaiHan ParentRecord { get; set; }
    }
}
