﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class NewspaperSubCategoryUserSubcribeDto : BaseDto
    {
        public string UserId { get; set; }
        public UserDto User { get; set; }

        public virtual NewspaperSubCategoryDto NewspaperSubCategory { get; set; }
    }
}
