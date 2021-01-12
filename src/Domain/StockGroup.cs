using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockGroup : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public float AvgEPS { get; set; }
        public float AvgPE { get; set; }
        public float AvgROA { get; set; }
        public float AvgROE { get; set; }
        public float AvgPrice { get; set; }
        public float ComparePrice { get; set; }
        public float AvgPB { get; set; }
        public float AvgBeta { get; set; }
        public long TongKL { get; set; }
        public long NNSoHuu { get; set; }
        public long VonTT { get; set; }
    }
}
