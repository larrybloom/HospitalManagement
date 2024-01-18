using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Data.Repository.Interface
{
    public interface IRepository<TEntity>
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(string id);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteRangeAsync(IEnumerable<TEntity> entities);
        Task<IQueryable<TEntity>> GetAllAsync2();
    }

}
