using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BlogCategory
    {
        public long? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public long? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
