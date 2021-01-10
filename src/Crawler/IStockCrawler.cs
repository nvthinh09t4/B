using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    public interface IStockCrawler
    {
        List<string> GetStockList();
        void CrawlerStockInformation();
    }
}
