using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockForeignerHolderRate : BaseEntity
    {
        public DateTime TakeDataAt { get; set; }
        public float MaximumCanHold { get; set; }
        public float CurrentHold { get; set; }
        public float RoomLeft { get; set; }
        public virtual StockCompany Company { get; set; }
    }
}
