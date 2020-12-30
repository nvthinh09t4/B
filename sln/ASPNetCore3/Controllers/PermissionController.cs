using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class PermissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Role()
        {
            return View();
        }

        public IActionResult Claim()
        {
            return View();
        }

        public IActionResult Policy()
        {
            return View();
        }
    }
}
