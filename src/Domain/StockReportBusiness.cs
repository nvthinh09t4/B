using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockReportBusiness : BaseEntity
    {
        public string Year { get; set; }
        public string Quarter { get; set; }
        public string Code { get; set; }

        public float TongDoanhThuHoatDongKinhDoanh { get; set; }
        public float CacKhoanGiamTruDoanhThu { get; set; }
        public float DoanhThuThuan { get; set; }
        public float GiaVonHangBan { get; set; }
        public float LoiNhuanGop { get; set; }
        public float DoanhThuHoatDongTaiChinh { get; set; }
        public float ChiPhiTaiChinh { get; set; }
        public float ChiPhiTaiChinh_ChiPhiLaiVay { get; set; }
        public float LoiNhuanHoacLoTrongCongTyLienKet { get; set; }
        public float ChiPhiBanHang { get; set; }

        public float ChiPhiQuanLyDoanhNghiep { get; set; }
        public float LoiNhuanThuanTuHoatDongKinhDoanh { get; set; }
        public float ThuNhapKhac { get; set; }
        public float ChiPhiKhac { get; set; }
        public float LoiNhuanKhac { get; set; }
        public float LoiNhuanHoacLoTrongCongTyLienKetTruoc2015 { get; set; }
        public float TongLoiNhuanKeToanTruocThue { get; set; }
        public float ChiPhiThueTNDN { get; set; }
        public float ChiPhiThueTNDN_HienHanh { get; set; }
        public float ChiPhiThueTNDN_HoanLai { get; set; }
        public float LoiNhuanSauThueTNDN { get; set; }
        public float LoiIchCoDongThieuSo { get; set; }
        public float LoiNhuanSauThueCuaCongTyMe { get; set; }

    }
}
