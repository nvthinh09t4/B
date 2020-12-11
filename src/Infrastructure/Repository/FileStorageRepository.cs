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
    public class FileStorageRepository : BaseRepository<FileStorage>, IFileStorageRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public FileStorageRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public async Task<List<FileStorage>> GetFilesByUserId(string userId)
        {
            await using var db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            return db.Query<FileStorage>("Select * from FileStorage where UserId = @UserId", new { userId }).ToList();
        }
    }
}
