using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;

namespace ASPNetCore3.Controllers
{
    public class NewsPaperController : Controller
    {
        public IActionResult Index()
        {
            using var reader = XmlReader.Create("https://thanhnien.vn/video/thoi-su.rss");
            var feed = SyndicationFeed.Load(reader);
            return View(feed.Items.ToList());
        }
    }
}
