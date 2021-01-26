using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_NoDaiHan : BaseEntity
    {
        public float TongCong { get; set; }

        public float PhaiTraDaiHanNguoiBan { get; set; }
        public float NguoiMuaTraTruocDaiHan { get; set; }
        public float ChiPhiPhaiTraDaiHan { get; set; }
        public float PhaiTraNoiBoVeVonKinhDoanh { get; set; }
        public float PhaiTraDaiHanNoiBo { get; set; }
        public float PhaiTraDaiHanKhac { get; set; }
        public float VayVaNoDaiHan { get; set; }
        public float TraiPhieuChuyenDoi { get; set; }
        public float CoPhieuUuDai { get; set; }
        public float ThueThuNhapHoanLaiPhaiTra { get; set; }
        public float DuPhongTroCapMatViecLam { get; set; }
        public float DoanhThuChuaThucHienDaiHan { get; set; }
        public float QuyPhatTrienKhoaHocVaCongNghe { get; set; }
        public float DuPhongPhaiTraDaiHan { get; set; }


        public long RPAB_NoPhaiTraId { get; set; }
        public virtual RPAB_NoPhaiTra ParentRecord { get; set; }
    }
}
