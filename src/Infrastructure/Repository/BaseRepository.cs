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
        protected ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await GetDBSet().AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            GetDBSet().Remove(entity);
        }

        public async virtual Task<T> GetById(long Id)
        {
            return await GetDBSet().AsQueryable().FirstOrDefaultAsync(x => x.Id == Id);
        }

        public DbSet<T> GetDBSet() => _dbContext.Set<T>();

        public async Task<T> UpdateAsync(T entity)
        {
            return DoUpdate(entity);
        }

        public async Task<T> SaveAsync(T entity)
        {
            var entityInDb = await GetDBSet().FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (entityInDb == null)
                return DoAdd(entity);
            return DoUpdate(entity);
        }

        public virtual T DoAdd(T entity) 
        {
            GetDBSet().Add(entity);
            return entity;
        }
        public virtual T DoUpdate(T entity)
        {
            GetDBSet().Update(entity);
            //_dbContext.Entry(entity).State = EntityState.Modified;
            //_dbContext.Entry(entity).CurrentValues.SetValues(entity);
            return entity;
        }

        public async Task<List<T>> UpdateRange(List<T> entities)
        {
            //foreach (var item in collection)
            //{

            //}
            return entities;
        }
    }
}
