using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.IServices
{
    public interface IStockCrawlerService : IWebCrawlerService
    {
        Task CrawlerStockGroupInformation(List<string> groups);


        void CrawlerVNDirectStockInformation();
        
        Task CrawlerStockInformation();
        Task CrawlerTransactionHistory();
        Task CrawlerReportAccountingBalance();
        Task CrawlerStockCompanyInformation(string code, ChromeDriver driver);
        Task CrawlerTransactionHistory(string code, ChromeDriver driver);
        Task CrawlerReportAccountingBalance(string code, ChromeDriver driver);
        Task CrawlerStockGroupInformation(string code, ChromeDriver driver);
        Task CrawlerCompanyInfor();
        Task CrawlerCompanyInfor(string code, ChromeDriver driver);
    }
}
