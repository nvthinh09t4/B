using ASPNetCore3.Models.DTO;
using ASPNetCore3.Models.VMIndex;
using AutoMapper;
using Domain;
using Domain.Enum;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        private IMapper _mapper;

        public BookController(IBookRepository bookRepository,
            IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public IActionResult Index(BookIndexViewModel model)
        {
            if (model == null)
                model = new BookIndexViewModel();

            //model.PagingData.Records = _mapper.Map<List<Book>, List<BookDto>>(_bookRepository.GetDBSet().ToList());
            //model.PagingData.TotalRecords = _bookRepository.GetDBSet().Count();

            return View(model);
        }

        public JsonResult GetBooks(EReadingStatus readingStatus, int pageSize, int pageIndex)
        {
            var books = _mapper.Map<List<Book>, List<BookDto>>(_bookRepository.GetDBSet().Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList());
            return Json(books);
        }
    }
}
