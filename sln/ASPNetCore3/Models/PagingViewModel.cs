using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models
{
    public class PagingViewModel<T> where T: class
    {
        public List<T> Records { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; } = 10;
        public int PageIndex { get; set; } = 1;
        public int TotalPage =>  (int)Math.Ceiling( 1.0 * TotalRecords / PageSize);
    }
}
