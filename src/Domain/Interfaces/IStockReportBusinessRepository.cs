using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStockReportBusinessRepository : IBaseRepository<StockReportBusiness>
    {
        Task<StockReportBusiness> GetByCodeOnTime(string code, string quarter, string year);
    }
}
