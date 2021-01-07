using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<FileStorage> Files { get; set; } = new List<FileStorage>();
        public virtual List<NewspaperUserSubcribe> NewspaperSubscribes { get; set; }
        public virtual List<NewspaperSubCategoryUserSubcribe> NewspaperSubCategorySubscribes { get; set; }
        public virtual List<NewspaperCategoryUserSubcribe> NewspaperCategoryUserSubcribes { get; set; }
    }
}
