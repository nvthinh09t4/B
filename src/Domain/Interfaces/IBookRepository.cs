﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        IList<Book> GetBookByReadingStatus(EReadingStatus readingStatus, int pageSize, int pageIndex);
    }
}
