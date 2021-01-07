using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    //category of a specific newspaper follow by user
    public class NewspaperSubCategoryUserSubcribe : BaseEntity
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public virtual NewspaperSubCategory NewspaperSubCategory { get; set; }
    }
}
