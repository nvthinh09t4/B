using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity.ReportAccountingBalance
{
    public class Criteria_VonVaCacQuy : BaseEntity
    {
        public float TongCong { get; set; }

        public float VonGop { get; set; }
        public float ThangDuVonCoPhan { get; set; }
        public float QuyenChonChuyenDoiTraiPhieu { get; set; }
        public float VonKhacCuaChuSoHuu { get; set; }
        public float CoPhieuQuy { get; set; }
        public float ChenhLenhDanhGiaLaiTaiSan { get; set; }
        public float ChenhLechTyGiaHoiDoai { get; set; }
        public float QuyDauTuPhatTrien { get; set; }
        public float QuyDuPhongTaiChinh { get; set; }
        public float QuyKhacThuocVonChuSoHuu { get; set; }
        public float LoiNhuanSauThueChuaPhanPhoi { get; set; }
        public float LoiIchCoDongKhongKiemSoat { get; set; }
        public float QuyHoTroSapXepDoanhNghiep { get; set; }
        public float NguonVonDauTuXDCB { get; set; }


        public long RPAB_VonChuSoHuuId { get; set; }
        public virtual RPAB_VonChuSoHuu ParentRecord { get; set; }
    }
}
