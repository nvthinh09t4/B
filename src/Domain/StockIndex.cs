using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockIndex : BaseEntity
    {
        public string InforDate { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public string Code { get; set; }
        public long KLGDTrongPhien { get; set; }
        public float GiaTran { get; set; }
        public float GiaSan { get; set; }
        public float GiaMoCua { get; set; }
        public float GiaCaoNhat { get; set; }
        public float GiaThapNhat { get; set; }
        public string VonHoaThiTruong { get; set; }
        public long KLGDTrungBinh10Phien { get; set; }
        public float CaoNhat52Tuan { get; set; }
        public float ThapNhat52Tuan { get; set; }
        public string SoCPLuuHanh { get; set; }
        public string FreeFloat { get; set; }
        public float Beta { get; set; }
        public float PE { get; set; }
        public float PB { get; set; }
        public float ROAE { get; set; }
        public float ROAA { get; set; }
        public string TySuatCoTuc { get; set; }
        public float EPS { get; set; }
        public float BVPS { get; set; }
    }
}
