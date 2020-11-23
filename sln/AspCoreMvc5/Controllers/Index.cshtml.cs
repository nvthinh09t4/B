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
    public class IndexModel : PageModel
    {
        private readonly AspCoreMvc5.Data.ApplicationDbContext _context;

        public IndexModel(AspCoreMvc5.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get;set; }

        public async Task OnGetAsync()
        {
            Speaker = await _context.Speakers.ToListAsync();
        }
    }
}
