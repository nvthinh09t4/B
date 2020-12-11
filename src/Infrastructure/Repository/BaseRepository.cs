using Domain.Common;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await GetDBSet().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            GetDBSet().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetById(long Id)
        {
            return GetDBSet().AsQueryable().FirstOrDefault(x => x.Id == Id);
        }

        public DbSet<T> GetDBSet() => _dbContext.Set<T>();

        public async Task<T> UpdateAsync(T entity)
        {
            GetDBSet().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
