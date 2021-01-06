using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class NewspaperUserSubcribe : BaseEntity
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public long? NewspaperId { get; set; }
        [ForeignKey("NewspaperId")]
        public virtual Newspaper Newspaper { get; set; }
        public long? NewspaperSubCategoryId { get; set; }
        [ForeignKey("NewspaperSubCategoryId")]
        public virtual NewspaperSubCategory NewspaperSubCategory { get; set; }
        public long? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get;set;}
    }
}
