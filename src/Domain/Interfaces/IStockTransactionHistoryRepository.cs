﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStockTransactionHistoryRepository : IBaseRepository<StockTransactionHistory>
    {
        StockTransactionHistory GetByCodeAndDate(string code, string date);
    }
}
