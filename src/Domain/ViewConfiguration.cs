using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ViewConfiguration : BaseEntity
    {
        public string ViewName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public long CategoryTypeId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
