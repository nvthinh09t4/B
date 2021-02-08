using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models
{
    public class StockViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
    public class StockIndexViewModel
    {
        [Display(Name = "Cập nhập nhóm cổ phiểu?")]
        public bool IsUpdateStockGroup { get; set; }
        [Display(Name = "Cập nhập thông tin công ty?")]
        public bool IsUpdateCompanyInfor { get; set; }
        [Display(Name = "Cập nhập bảng cân đối kế toán?")]
        public bool IsUpdateStockReportAccountingBalance { get; set; }
        [Display(Name = "Cập nhập báo cáo kết quả kinh doanh?")]
        public bool IsUpdateStockReportBusiness { get; set; }
        [Display(Name = "Cập nhập lịch sử giao dịch?")]
        public bool IsUpdateStockTransactionHistory { get; set; }
        [Display(Name = "Cập nhập thông tin chung của cổ phiếu?")]
        public bool IsUpdateStockMainInformation { get; set; }
        [Display(Name = "Danh sách cổ phiếu (không nhập thì cập nhập tất cả)")]
        public string[] SpecificStock { get; set; }
        [Display(Name = "Danh sách nhóm cổ phiếu (không nhập thì cập nhập tất cả)")]
        public List<string> SpecificGroup { get; set; }
        public List<StockViewModel> Stocks { get; set; } = new List<StockViewModel>();
    }
}
