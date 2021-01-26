using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_NoNganHan : BaseEntity
    {
        public float TongCong { get; set; }

        public float VayVaNoNganHan { get; set; }
        public float PhaiTraNguoiBan { get; set; }
        public float NguoiMuaTraTienTruoc { get; set; }
        public float ThueVaCacKhoanPhaiNopNhaNuoc { get; set; }
        public float PhaiTraNguoiLaoDong { get; set; }
        public float ChiPhiPhaiTra { get; set; }
        public float PhaiTraNoiBo { get; set; }
        public float PhaiTraTheoTienDoKeHoachHopDongXayDung { get; set; }
        public float CacKhoanPhaiTraPhaiNopNganHanKhac { get; set; }
        public float QuyKhenThuongPhucLoi { get; set; }
        public float DoanhThuChuaThucHienNganHan { get; set; }
        public float DuPhongPhaiTraNganHan { get; set; }
        public float QuyBinhOnGia { get; set; }
        public float GiaoDichMuaBanLaiTraiPhieuChinhPhu { get; set; }


        public long RPAB_NoPhaiTraId { get; set; }
        public virtual RPAB_NoPhaiTra ParentRecord { get; set; }
    }
}
