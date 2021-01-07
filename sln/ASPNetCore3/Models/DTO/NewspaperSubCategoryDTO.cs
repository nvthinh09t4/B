using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class NewspaperSubCategoryDTO
    {
        public long NewspaperId { get; set; }
        public Newspaper Newspaper { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual List<NewspaperSubCategoryUserSubcribe> UserSubcribes { get; set; }
    }
}
