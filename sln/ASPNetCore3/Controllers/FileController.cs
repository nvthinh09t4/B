using ASPNetCore3.Models;
using Domain;
using Domain.Interfaces;
using ExternalAPIs.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    [Authorize]
    public class FileController : Controller
    {
        public FileController(IGoogleDriveAPI driveAPI, 
            IHostingEnvironment hostingEnvironment, 
            UserManager<ApplicationUser> userManager,
            IFileStorageRepository fileStorageRepository)
        {
            _driveAPI = driveAPI;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _fileStorageRepository = fileStorageRepository;
        }

        public IGoogleDriveAPI _driveAPI { get; }

        private IHostingEnvironment _hostingEnvironment;
        private UserManager<ApplicationUser> _userManager;
        private IFileStorageRepository _fileStorageRepository;

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var fileStorages = await _fileStorageRepository.GetFilesByUserId(currentUser.Id);
            var model = new UploadFileViewModel { 
                Files = fileStorages
            };
            return View(model);
        }

        public IActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        [RequestSizeLimit(100_000_000)]
        public async Task< IActionResult> UploadFile(UploadFileViewModel model)
        {
            if (model.FileUpload != null && model.FileUpload.Length > 0)
            {
                var fileName = model.FileUpload.FileName;
                var fileExtension = Path.GetExtension(fileName);
                var fileId = Guid.NewGuid();
                var newFileName = $"{fileId:N}{fileExtension}";
                

                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                var relativePath = Path.Combine("FileUpload", currentUser!=null ? currentUser.UserName : "", DateTime.Now.ToString("ddMMyyyy"), newFileName);
                string storagePath = Path.Combine(_hostingEnvironment.ContentRootPath, relativePath);
                if (!string.IsNullOrEmpty(storagePath))
                {
                    var directory = Path.GetDirectoryName(storagePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                }

                using (var fileStream = new FileStream(storagePath, FileMode.CreateNew))
                {
                    await model.FileUpload.CopyToAsync(fileStream);
                }

                
                if (currentUser != null)
                {
                    await _fileStorageRepository.CreateAsync(new FileStorage {
                        OriginFileExtension = fileExtension,
                        OriginFileName = fileName,
                        OriginFullPath = storagePath,
                        StorageFileExtension = fileExtension,
                        StorageFileName = newFileName,
                        StorageFullPath = relativePath,
                        FileName = fileName,
                        UserId = currentUser.Id
                    });
                }

            }
            //using (var ms = new MemoryStream())
            //{
            //    await model.FileUpload.CopyToAsync(ms);
            //    await _driveAPI.UploadFile(ms.ToArray());
            //}
            
            return RedirectToAction("Index");
        }
    }
}
