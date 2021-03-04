using ASPNetCore3.Helper;
using ASPNetCore3.IServices;
using ASPNetCore3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IViewRenderService _viewRenderService;

        public HomeController(ILogger<HomeController> logger, IViewRenderService viewRenderService)
        {
            _logger = logger;
            _viewRenderService = viewRenderService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new EmptyViewModel();
            var test = await _viewRenderService.RenderToStringAsync("Home/Index", model);
            //return Redirect("Stock/Index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
