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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetCategoryOfUser(string userId)
        {
            await using var db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return db.Query<Category>("select * from Category").ToList();
        }
    }
}
