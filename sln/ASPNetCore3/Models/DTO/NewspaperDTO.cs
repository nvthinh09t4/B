using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class NewspaperDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string LogoBase64 { get; set; }
        public virtual List<NewspaperSubCategoryDTO> SubCategories { get; set; }
    }
}
