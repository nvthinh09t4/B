﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspCoreMvc5.Data;

namespace AspCoreMvc5.Controllers
{
    public class CreateModel : PageModel
    {
        private readonly AspCoreMvc5.Data.ApplicationDbContext _context;

        public CreateModel(AspCoreMvc5.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Speaker Speaker { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Speakers.Add(Speaker);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
