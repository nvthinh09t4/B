using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspCoreMvc5.Data;

namespace AspCoreMvc5.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly AspCoreMvc5.Data.ApplicationDbContext _context;

        public DetailsModel(AspCoreMvc5.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Speaker Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Speaker = await _context.Speakers.FirstOrDefaultAsync(m => m.Id == id);

            if (Speaker == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
