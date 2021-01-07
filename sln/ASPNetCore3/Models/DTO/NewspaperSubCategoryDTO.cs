using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class NewspaperSubCategoryDto : BaseDto
    {
        public long NewspaperId { get; set; }
        public NewspaperDto Newspaper { get; set; }
        public long CategoryId { get; set; }
        public CategoryDto Category { get; set; }

        public virtual List<NewspaperSubCategoryUserSubcribeDto> UserSubcribes { get; set; }
    }
}
