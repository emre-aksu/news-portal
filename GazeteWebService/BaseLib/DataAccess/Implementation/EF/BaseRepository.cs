using BaseLib.DataAccess.Contracts;
using BaseLib.Model;
using Microsoft.EntityFrameworkCore;

namespace BaseLib.DataAccess.Implementation.EF
{
    public class BaseRepository<TEntity, TId, TContext> : IRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TContext : DbContext, new()
    {
        // git deneme
        public async Task DeleteAsync(TEntity entity)
        {
            using TContext ctx = new();
            ctx.Set<TEntity>().Remove(entity);
            await ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(TId id)
        {
            var entity = await GetByIdAsync(id);
            using TContext ctx = new();
            ctx.Set<TEntity>().Remove(entity);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(params string[] includeList)
        {
            using TContext ctx = new();
            IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
            if(includeList != null&& includeList.Length > 0)
            {
                foreach(var item  in includeList)
                {
                    dbSet= dbSet.Include(item);
                }
            }
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TId id, params string[] includeList)
        {
            using TContext ctx = new();
            IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
            if (includeList != null)
            {
                foreach (var item in includeList)
                    dbSet = dbSet.Include(item);
            }
            return await dbSet.SingleOrDefaultAsync(x=> x.Id.Equals(id));
        }

        public async Task InsertAsync(TEntity entity)
        {
            using(TContext ctx = new())
            {
                await ctx.Set<TEntity>().AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
           using TContext ctx = new();  
            ctx.Set<TEntity>().Update(entity);
            await ctx.SaveChangesAsync();  
        }
    }
}
