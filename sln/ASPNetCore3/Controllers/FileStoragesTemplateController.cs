using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Infrastructure.Data;

namespace ASPNetCore3.Controllers
{
    public class FileStoragesTemplateController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FileStoragesTemplateController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FileStoragesTemplate
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FileStorage.Include(f => f.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FileStoragesTemplate/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileStorage = await _context.FileStorage
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fileStorage == null)
            {
                return NotFound();
            }

            return View(fileStorage);
        }

        // GET: FileStoragesTemplate/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: FileStoragesTemplate/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OriginFullPath,OriginFileName,OriginFileExtension,StorageFullPath,StorageFileName,StorageFileExtension,FilePath,FileName,IsDisable,UploadAt,UserId,Id,CreatedOn,LastModifiedOn,CreatedBy,LastModifiedBy")] FileStorage fileStorage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fileStorage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", fileStorage.UserId);
            return View(fileStorage);
        }

        // GET: FileStoragesTemplate/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileStorage = await _context.FileStorage.FindAsync(id);
            if (fileStorage == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", fileStorage.UserId);
            return View(fileStorage);
        }

        // POST: FileStoragesTemplate/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("OriginFullPath,OriginFileName,OriginFileExtension,StorageFullPath,StorageFileName,StorageFileExtension,FilePath,FileName,IsDisable,UploadAt,UserId,Id,CreatedOn,LastModifiedOn,CreatedBy,LastModifiedBy")] FileStorage fileStorage)
        {
            if (id != fileStorage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fileStorage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileStorageExists(fileStorage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", fileStorage.UserId);
            return View(fileStorage);
        }

        // GET: FileStoragesTemplate/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileStorage = await _context.FileStorage
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fileStorage == null)
            {
                return NotFound();
            }

            ViewBag.Id = id;

            return PartialView("_Delete");
        }

        // POST: FileStoragesTemplate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var fileStorage = await _context.FileStorage.FindAsync(id);
            _context.FileStorage.Remove(fileStorage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FileStorageExists(long id)
        {
            return _context.FileStorage.Any(e => e.Id == id);
        }
    }
}
