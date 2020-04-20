using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3_Adriana_Kenny.web.Entities;

namespace PE3_Adriana_Kenny.web.Data
{
    public interface IRepository <T, Tkey> where T : BaseEntity <Tkey>
    {
        Task<T> GetByIdAsync(Tkey id);
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
