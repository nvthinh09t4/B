using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IStockIndexRepository : IBaseRepository<StockIndex>
    {
        StockIndex GetStockInformationByCodeAndDate(string code, string date);
    }
}
