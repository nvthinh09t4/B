using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStockReportAccountingBalanceRepository : IBaseRepository<StockReportAccountingBalance>
    {
        Task<StockReportAccountingBalance> GetByCodeOnTime(string code, string quarter, string year);
    }
}
