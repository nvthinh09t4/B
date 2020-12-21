using ASPNetCore3.Models;
using Domain;
using Domain.Interfaces;
using ExternalAPIs.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            IFileStorageRepository fileStorageRepository,
            ICategoryRepository categoryRepository,
            IFileCategoryRepository fileCategoryRepository)
        {
            _driveAPI = driveAPI;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _fileStorageRepository = fileStorageRepository;
            _categoryRepository = categoryRepository;
            _fileCategoryRepository = fileCategoryRepository;
        }

        public IGoogleDriveAPI _driveAPI { get; }

        private IHostingEnvironment _hostingEnvironment;
        private UserManager<ApplicationUser> _userManager;
        private IFileStorageRepository _fileStorageRepository;
        private ICategoryRepository _categoryRepository;
        private IFileCategoryRepository _fileCategoryRepository;

        public async Task<IActionResult> Index(long? categoryId)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var fileStorages = await _fileStorageRepository.GetFilesByUserId(currentUser.Id);
            if (categoryId.HasValue)
                fileStorages = fileStorages.Where(x => x.Categories != null && x.Categories.Select(x => x.CategoryId).Contains(categoryId.Value));
            var categories = await _categoryRepository.GetCategoryOfUser(currentUser.Id);
            ViewBag.CategoryList = categories.Select(x => new SelectListItem {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            var model = new UploadFileViewModel { 
                Files = fileStorages.ToList()
            };
            return View(model);
        }

        public IActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        [RequestSizeLimit(500_000_000)]
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
                string storagePath = Path.Combine(_hostingEnvironment.WebRootPath, relativePath);
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
                    var fileStorage = new FileStorage {
                        OriginFileExtension = fileExtension,
                        OriginFileName = fileName,
                        OriginFullPath = storagePath,
                        StorageFileExtension = fileExtension,
                        StorageFileName = newFileName,
                        StorageFullPath = relativePath,
                        FileName = fileName,
                        UserId = currentUser.Id,
                    };
                    foreach (var item in model.CategoriesID)
                    {
                        fileStorage.Categories.Add(new FileCategory {
                            File = fileStorage,
                            Category = await _categoryRepository.GetById(item)
                        }) ;
                    }

                    await _fileStorageRepository.CreateAsync(fileStorage);
                    

                    //await _fileCategoryRepository.Create(fileCategories);
                }

            }
            //using (var ms = new MemoryStream())
            //{
            //    await model.FileUpload.CopyToAsync(ms);
            //    await _driveAPI.UploadFile(ms.ToArray());
            //}
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> View(string name)
        {
            var file = await _fileStorageRepository.GetFileByAlternativeName(name);
            //var bytes = ReadAllBytes(file.OriginFullPath);
            //var base64 = Convert.ToBase64String(bytes);
            return View(new PDFViewerModel {
                FilePath = file.StorageFullPath,
                FileName = file.OriginFileName,
                //Base64String = base64
            });
        }
        //C:\inetpub\wwwroot
        //The.Fellowship.of.the.Ring.2001.mp4

        public IActionResult Video()
        {
            return View();
        }

        public async Task<PhysicalFileResult> StreamVideo()
        {
            return PhysicalFile(@"C:\inetpub\wwwroot\The.Fellowship.of.the.Ring.2001.mkv", "application/octet-stream", enableRangeProcessing: true);
        }

        public byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;
        }

        public async Task<IActionResult> Delete(string filename)
        {
            var file = await _fileStorageRepository.GetFileByAlternativeName(filename);
            System.IO.File.Delete(file.OriginFullPath);
            await _fileStorageRepository.DeleteAsync(file);
            return RedirectToAction("Index");
        }
    }
}
