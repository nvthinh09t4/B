using Dapper;
using Domain;
using Domain.Enum;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public BookRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public IList<Book> GetBookByReadingStatus(EReadingStatus readingStatus, int pageSize = 10, int pageIndex = 1)
        {
            return _dbContext.Book.Where(x => x.ReadingStatus == readingStatus).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
        }
    }
}
