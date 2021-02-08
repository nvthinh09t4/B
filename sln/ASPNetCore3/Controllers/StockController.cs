using ASPNetCore3.IServices;
using ASPNetCore3.Models;
using Crawler;
using Domain.Interfaces;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private IRepositoryWrapper _repositoryWrapper;

        public StockController(IStockCrawlerService stockCrawler, IRepositoryWrapper repositoryWrapper) 
        {
            _stockCrawler = stockCrawler;
            _repositoryWrapper = repositoryWrapper;
        }
        public IActionResult Index()
        {
            //_stockCrawler.CrawlerVNDirectStockInformation();
            //_stockCrawler.CrawlerStockInformation();

            ViewBag.StockGroup = _repositoryWrapper.StockGroup.GetDBSet().Select(x => new SelectListItem {
                Text = x.Name,
                Value = x.Code
            }).ToList();

            ViewBag.StockIndex = _repositoryWrapper.StockIndex.GetDBSet().Select(x => new SelectListItem {
                Text = x.Code,
                Value = x.Code
            }).ToList();

            return View(new StockIndexViewModel());
        }

        public async Task<IActionResult> UpdateStock(StockIndexViewModel model)
        {
            if (model.IsUpdateStockGroup)
                await _stockCrawler.CrawlerStockGroupInformation(model.SpecificGroup);

            if (model.IsUpdateCompanyInfor)
                await _stockCrawler.CrawlerCompanyInfor();

            if (model.IsUpdateStockMainInformation)
                await _stockCrawler.CrawlerStockInformation();

            if (model.IsUpdateStockReportAccountingBalance)
                await _stockCrawler.CrawlerReportAccountingBalance();

            if (model.IsUpdateStockTransactionHistory)
                await _stockCrawler.CrawlerTransactionHistory();

            if (model.IsUpdateStockReportBusiness)
                await _stockCrawler.CrawlerReportBusiness();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> UpdateStockInformation()
        {
            await _stockCrawler.CrawlerStockInformation();
            return Redirect("Index");
        }

        public async Task<IActionResult> UpdateStockPriceEveryDate()
        {
            //await _stockCrawler.CrawlerTransactionHistory();
            return Redirect("Index");
        }

        public async Task<IActionResult> UpdateStockReport()
        {
            await _stockCrawler.CrawlerStockInformation();
            return Redirect("Index");
        }
    }
}
