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
    public class NewspaperSubCategoryRepository : INewspaperSubCategoryRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;
        public DbSet<NewspaperSubCategory> GetDBSet() => _dbContext.Set<NewspaperSubCategory>();

        public NewspaperSubCategoryRepository(ApplicationDbContext dbContext, IConfiguration configuration) 
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public async Task<NewspaperSubCategory> Create(NewspaperSubCategory NewspaperSubCategory)
        {
            await _dbContext.Set<NewspaperSubCategory>().AddAsync(NewspaperSubCategory);
            await _dbContext.SaveChangesAsync();
            return NewspaperSubCategory;
        }

        public void Delete(NewspaperSubCategory NewspaperSubCategory)
        {
            _dbContext.Remove(NewspaperSubCategory);
            _dbContext.SaveChanges();
        }

        public async Task<List<NewspaperSubCategory>> Create(List<NewspaperSubCategory> fileCategories)
        {
            await _dbContext.Set<NewspaperSubCategory>().AddRangeAsync(fileCategories);
            await _dbContext.SaveChangesAsync();
            return fileCategories;
        }
    }
}
