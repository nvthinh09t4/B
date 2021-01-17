using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockShareholder : BaseEntity
    {
        public string Name { get; set; }
        public float SharePercent { get; set; }
        public virtual StockCompany Company { get; set; }
    }
}
