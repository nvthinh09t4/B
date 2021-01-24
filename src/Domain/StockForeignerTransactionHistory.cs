using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class StockForeignerTransactionHistory : BaseEntity
    {
        public DateTime TransactionDate { get; set; }

    }
}
