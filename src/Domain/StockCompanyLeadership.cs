using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockCompanyLeadership : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public virtual StockCompany Company { get; set; }
    }
}
