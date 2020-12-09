using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<FileStorage> Files { get; set; } = new List<FileStorage>();
    }
}
