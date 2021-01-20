using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class StockCompany : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string ListedAt { get; set; }
        public string BusinessArea { get; set; }
        public List<StockCompanyLeadership> Leaderships { get; set; } = new List<StockCompanyLeadership>();
        public List<StockShareholder> MainShareholder { get; set; } = new List<StockShareholder>();
        public virtual List<StockForeignerHolderRate> ForeignerHolderRates { get; set; }
    }
}
