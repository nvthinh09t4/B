using ASPNetCore3.Models;
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
        public IActionResult Index()
        {
            HtmlDocument webDocument = new HtmlDocument();
            webDocument.Load(@"C:\Users\nvthi\source\repos\B\sln\ASPNetCore3\wwwroot\htmlpage\hose.html");
            var model = new StockIndexViewModel();
            foreach (var tr in webDocument.DocumentNode.SelectNodes("//table[@id='banggia-khop-lenh']//tr"))
            {
                model.Stocks.Add(new StockViewModel {
                    Code = tr.GetAttributeValue("id", "unknown"),
                    Name = tr.ChildNodes.FirstOrDefault(x => x.GetAttributes("class").Select(x => x.Value).Contains("company-tooltip")).InnerText
                });; ;
            }
            return View(model);
        }
    }
}
