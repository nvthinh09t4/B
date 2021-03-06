﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    //newspaper follow by user
    public class NewspaperUserSubcribe : BaseEntity
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public long NewspaperId { get; set; }
        [ForeignKey("NewspaperId")]
        public virtual Newspaper Newspaper { get; set; }
    }
}
