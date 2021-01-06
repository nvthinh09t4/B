using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class NewspaperSubCategory
    {
        public long NewspaperId { get; set; }
        [ForeignKey("NewspaperId")]
        public Newspaper Newspaper { get; set; }
        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
