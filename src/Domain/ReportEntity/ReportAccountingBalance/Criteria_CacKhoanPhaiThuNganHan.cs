using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_CacKhoanPhaiThuNganHan : BaseEntity
    {
        public float TongCong { get; set; }
        public float PhaiThuKhachHang { get; set; }
        public float TraTruocChoNguoiBan { get; set; }
        public float PhaiThuNoiBoNganHan { get; set; }
        public float PhaiThuTheoTienDoKeHoachHopDongXayDung { get; set; }
        public float PhaiThuVeChoVayNganHan { get; set; }
        public float CacKhoanPhaiThuKhac { get; set; }
        public float DuPhongPhaiThuNganHanKhoDoi { get; set; }
        public float TaiSanThieuChoXuLy { get; set; }

        public long RPAB_TaiSanNganHanId { get; set; }
        public virtual RPAB_TaiSanNganHan ParentRecord { get; set; }
    }
}
