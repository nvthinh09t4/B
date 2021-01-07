using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Infrastructure.Data;
using ASPNetCore3.Models;

namespace ASPNetCore3.Controllers
{
    public class NewspapersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewspapersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Newspapers
        public async Task<IActionResult> Index(NewspaperIndexViewModel model)
        {
            return View(await _context.Newspaper.ToListAsync());
        }

        // GET: Newspapers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newspaper = await _context.Newspaper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newspaper == null)
            {
                return NotFound();
            }

            return View(newspaper);
        }

        // GET: Newspapers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Newspapers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedOn,LastModifiedOn,CreatedBy,LastModifiedBy")] Newspaper newspaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newspaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newspaper);
        }

        // GET: Newspapers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newspaper = await _context.Newspaper.FindAsync(id);
            if (newspaper == null)
            {
                return NotFound();
            }
            return View(newspaper);
        }

        // POST: Newspapers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Name,Id,CreatedOn,LastModifiedOn,CreatedBy,LastModifiedBy")] Newspaper newspaper)
        {
            if (id != newspaper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newspaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewspaperExists(newspaper.Id))
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
            return View(newspaper);
        }

        // GET: Newspapers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newspaper = await _context.Newspaper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newspaper == null)
            {
                return NotFound();
            }

            return View(newspaper);
        }

        // POST: Newspapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var newspaper = await _context.Newspaper.FindAsync(id);
            _context.Newspaper.Remove(newspaper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewspaperExists(long id)
        {
            return _context.Newspaper.Any(e => e.Id == id);
        }
    }
}
