namespace DataAccess.Concrete
{
    public class EfBaseRepository<TEntity, TDBContext> : IBaseRepository<TEntity> where TEntity : class, IEntity, new()
    where TDbContext : DbContext, new()
    {
        public Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TDbContext context = new TDbContext())
            {
                return filter == null
                    ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
                
            }
}

public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
{
    return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
}

public Task<TEntity> AddAsync(TEntity entity)
{
    throw new NotImplementedException();
}

public Task<TEntity> UpdateAsync(TEntity entity)
{
    throw new NotImplementedException();
}

public Task<bool> DeleteAsync(int id)
{
    throw new NotImplementedException();
}
    }
}
