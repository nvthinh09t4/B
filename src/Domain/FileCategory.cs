using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class FileCategory 
    {
        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public long FileStorageId { get; set; }
        [ForeignKey("FileStorageId")]
        public virtual FileStorage File { get; set; }
    }
}
