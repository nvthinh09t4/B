using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class NewspaperDto : BaseDto
    {
        public long Id { get; set; }
        [Display(Name = "Tên báo")]
        public string Name { get; set; }
        [Display(Name = "Link")]
        public string Url { get; set; }
        [Display(Name = "Logo")]
        public string LogoBase64 { get; set; }
        public virtual List<NewspaperSubCategoryDto> SubCategories { get; set; }
    }
}
