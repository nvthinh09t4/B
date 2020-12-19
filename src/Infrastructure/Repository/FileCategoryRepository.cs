using Dapper;
using Domain;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class FileCategoryRepository : IFileCategoryRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;
        public DbSet<FileCategory> GetDBSet() => _dbContext.Set<FileCategory>();

        public FileCategoryRepository(ApplicationDbContext dbContext, IConfiguration configuration) 
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public async Task<FileCategory> Create(FileCategory fileCategory)
        {
            await _dbContext.Set<FileCategory>().AddAsync(fileCategory);
            await _dbContext.SaveChangesAsync();
            return fileCategory;
        }

        public void Delete(FileCategory fileCategory)
        {
            _dbContext.Remove(fileCategory);
            _dbContext.SaveChanges();
        }

        public async Task<List<FileCategory>> Create(List<FileCategory> fileCategories)
        {
            await _dbContext.Set<FileCategory>().AddRangeAsync(fileCategories);
            await _dbContext.SaveChangesAsync();
            return fileCategories;
        }
    }
}
