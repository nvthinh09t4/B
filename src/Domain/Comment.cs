using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int UpPoint { get; set; }
        public int DownPoint { get; set; }
        public string UserId { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public long? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
