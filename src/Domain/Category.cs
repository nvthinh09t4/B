using Domain.Common;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public long CategoryTypeId { get; set; }
        [ForeignKey("CategoryTypeId")]
        public CategoryType Type { get; set; }
        public string Display { get; set; }
        public virtual List<FileCategory> Files { get; set; }
        public virtual List<NewspaperSubCategory> Newspapers { get; set; }
        public EStatus Status { get; set; }
    }
}
