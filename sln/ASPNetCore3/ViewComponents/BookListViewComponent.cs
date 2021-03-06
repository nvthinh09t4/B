using Domain.Enum;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.ViewComponents
{
    public class BookListViewComponent : ViewComponent
    {
        private IBookRepository _bookRepository;

        public BookListViewComponent(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync(EReadingStatus readingStatus)
        {
            return View();
        }
    }
}
