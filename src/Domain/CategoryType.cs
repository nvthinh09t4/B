using Domain.Common;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CategoryType : BaseEntity
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public EStatus Status { get; set; }
    }
}
