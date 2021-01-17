using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.IServices
{
    public interface IStockCrawlerService : IWebCrawlerService
    {
        void CrawlerVNDirectStockInformation();
        Task CrawlerStockGroupInformation();
        Task CrawlerStockInformation();
        Task CrawlerStockCompanyInformation();
    }
}
