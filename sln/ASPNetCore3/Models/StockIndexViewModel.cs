using System;
using System.Collections.Generic;
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
        public List<StockViewModel> Stocks { get; set; } = new List<StockViewModel>();
    }
}
