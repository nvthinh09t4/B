using Dapper;
using Domain;
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
    public class NewspaperUserSubcribeRepository : BaseRepository<NewspaperUserSubcribe>, INewspaperUserSubcribeRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public NewspaperUserSubcribeRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }
    }
}
