using CSharp.UnitTesting.Api.Data.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Services.Interfaces.Base
{
    public interface IServiceBase<TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TId id);
        Task<IEnumerable<TEntity>> GetByIdsAsync(IEnumerable<TId> ids);

        Task CreateAsync(TEntity entity);
        Task CreateBulkAsync(IEnumerable<TEntity> entity);

        Task UpdateAsync(TEntity entity, TId id);
        Task UpdateBulkAsync(IEnumerable<TEntity> entity);

        Task DeleteAsync(TId id);
        Task DeleteBulkAsync(IEnumerable<TId> ids);
    }
}
