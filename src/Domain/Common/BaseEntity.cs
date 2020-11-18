using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
