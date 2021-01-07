using ASPNetCore3.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models.VMIndex
{
    public class BaseIndexViewModel<TDto> where TDto : BaseDto
    {
        public PagingViewModel<TDto> PagingData { get; set; }
        public string SearchString { get; set; }
    }
}
