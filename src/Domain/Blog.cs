using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set;}
        public int UpPoint { get; set; }
        public int DownPoint { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<BlogCategory> BlogCategories { get; set; }
    }
}
