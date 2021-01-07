using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models
{
    public class NewspaperIndexViewModel
    {
        public PagingViewModel<Newspaper> Data { get; set; }
    }
}
