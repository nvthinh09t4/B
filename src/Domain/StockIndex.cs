using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockIndex : BaseEntity
    {
        public string Code { get; set; }
        public string KLGDTrongPhien { get; set; }
        public string GiaTran { get; set; }
        public string GiaSan { get; set; }
        public string GiaMoCua { get; set; }
        public string GiaCaoNhat { get; set; }
        public string GiaThapNhat { get; set; }
        public string VonHoaThiTruong { get; set; }
        public string KLGDTrungBinh10Phien { get; set; }
        public string CaoNhat52Tuan { get; set; }
        public string ThapNhat52Tuan { get; set; }
        public string SoCPLuuHanh { get; set; }
        public string FreeFloat { get; set; }
        public string Beta { get; set; }
        public string PE { get; set; }
        public string PB { get; set; }
        public string ROAE { get; set; }
        public string ROAA { get; set; }
        public string TySuatCoTuc { get; set; }
        public string EPS { get; set; }
        public string BVPS { get; set; }
    }
}
