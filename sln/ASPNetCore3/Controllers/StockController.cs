using ASPNetCore3.IServices;
using ASPNetCore3.Models;
using Crawler;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class StockController : Controller
    {
        private IStockCrawlerService _stockCrawler;

        public StockController(IStockCrawlerService stockCrawler) 
        {
            _stockCrawler = stockCrawler;
        }
        public IActionResult Index()
        {
            //_stockCrawler.CrawlerVNDirectStockInformation();
            //_stockCrawler.CrawlerStockInformation();

            return View();
        }

        public async Task<IActionResult> UpdateStockGroup()
        {
            await _stockCrawler.CrawlerStockGroupInformation();
            return Redirect("Index");
        }

        public async Task<IActionResult> UpdateStockInformation()
        {
            await _stockCrawler.CrawlerStockInformation();
            return Redirect("Index");
        }
    }
}
