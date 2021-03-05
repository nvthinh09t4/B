using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.DTO
{
    public class BookDto : BaseDto
    {
        public string Name { get; set; }
        public string CreatedAt { get; set; }
    }
}
