using ASPNetCore3.Models;
using ExternalAPIs.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class FileController : Controller
    {
        public FileController(IGoogleDriveAPI driveAPI)
        {
            _driveAPI = driveAPI;
        }

        public IGoogleDriveAPI _driveAPI { get; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> UploadFile(UploadFileViewModel model)
        {
            using (var ms = new MemoryStream())
            {
                await model.FileUpload.CopyToAsync(ms);
                await _driveAPI.UploadFile(ms.ToArray());
            }
            
            return RedirectToAction("Index");
        }
    }
}
