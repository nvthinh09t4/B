﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Newspaper : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<NewspaperSubCategory> SubCategories { get; set; }
    }
}
