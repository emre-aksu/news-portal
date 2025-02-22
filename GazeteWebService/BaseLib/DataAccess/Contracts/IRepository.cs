using BaseLib.Model;

namespace BaseLib.DataAccess.Contracts
{
    public interface IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        Task<List<TEntity>> GetAllAsync(params string[] includeList);
        Task<TEntity> GetByIdAsync(TId id, params string[] includeList);
        Task InsertAsync(TEntity entity);   
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(TId id);   

    }
}
