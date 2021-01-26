using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryWrapper
    {
        IStockShareholderRepository StockShareholder { get; }
        IStockCompanyLeadershipRepository StockCompanyLeadership { get; }
        IStockCompanyRepository StockCompany { get; }
        IStockIndexRepository StockIndex { get; }
        IStockGroupRepository StockGroup { get; }
        IStockMainInformationRepository StockMainInformation { get; }
        IStockTransactionHistoryRepository StockTransactionHistory { get; }
        IStockReportAccountingBalanceRepository StockReportAccountingBalance { get; }

        void SaveChange();
        Task SaveChangeAsync();
    }
}
