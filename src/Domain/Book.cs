using Domain.Common;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Book : BaseEntity
    {
        public EReadingStatus ReadingStatus { get; set; }
        public long FileStorageId { get; set; }
        public virtual FileStorage FileStorage { get;set;}
    }
}
