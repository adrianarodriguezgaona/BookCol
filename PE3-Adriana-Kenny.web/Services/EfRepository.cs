using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PE3_Adriana_Kenny.web.Data;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Services
{
    public class EfRepository<T, TKey> : IRepository<T, TKey>
        where T : BaseEntity<TKey>
    {

        protected readonly BookingContext _dbContext;

        public EfRepository(BookingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetByIdAsync(TKey id)
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id.Equals(id));
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();

        }
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
