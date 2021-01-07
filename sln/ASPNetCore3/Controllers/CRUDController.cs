using ASPNetCore3.Models.DTO;
using Domain.Common;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class CRUDController<T, TDto> : Controller 
        where T : BaseEntity 
        where TDto : BaseDto
    {
        private IBaseRepository<T> _repository;

        public CRUDController(IBaseRepository<T> repository) 
        {
            _repository = repository;
        }

        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
