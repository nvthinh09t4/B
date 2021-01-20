using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IRepositoryWrapper
    {
        IStockShareholderRepository StockShareholder { get; }
        IStockCompanyLeadershipRepository StockCompanyLeadership { get; }
        IStockCompanyRepository StockCompany { get; }
        IStockIndexRepository StockIndex { get; }

        void Save();
    }
}
