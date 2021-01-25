using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class StockTransactionHistory : BaseEntity
    {
        public DateTime TransactionDate { get; set; }
        [NotMapped]
        public string TransactionDateString => TransactionDate.ToString("dd/MM/yyyy");
        public string Code { get; set; }
        public float ThayDoiDiem { get; set; }
        public float ThayDoiPhanTram { get; set; }
        public float GiaMoCua { get; set; }
        public float GiaThapNhat { get; set; }
        public float GiaCaoNhat { get; set; }
        public float GiaDongCua { get; set; }
        public float GiaBinhQuan { get; set; }
        public float GiaDongCuaDieuChinh { get; set; }
        public long KhoiLuongKhopLenh { get; set; }
        public long KhoiLuongThoaThuan { get; set; }
    }
}
