using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Newspaper : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string LogoBase64 { get; set; }
        public virtual List<NewspaperSubCategory> SubCategories { get; set; }
    }
}
