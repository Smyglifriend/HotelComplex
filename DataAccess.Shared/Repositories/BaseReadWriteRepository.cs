using HotelComplex.DataAccess.Shared.Abstractions.Interfaces;
using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HotelComplex.DataAccess.Shared.Repositories;

internal class BaseReadWriteRepository<TEntity>
    : BaseReadonlyRepository<TEntity>,
      IBaseReadWriteRepository<TEntity> 
    where TEntity : class, IEntity
{
    public BaseReadWriteRepository(DbContext dbContext) 
        : base(dbContext)
    {
    }

    public virtual async Task<long> SaveAsync(TEntity model)
    {
        await _dbSet.AddAsync(model);
        await _dbContext.SaveChangesAsync();
        
        return model.Id;
    }

    public async Task<TEntity> UpdateAsync(TEntity model)
    {
        _dbSet.Update(model);
        await _dbContext.SaveChangesAsync();
        return model;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task RemoveAsync(TEntity model)
    {
        _dbContext.Remove(model);
        await _dbContext.SaveChangesAsync();
    }

    public virtual async Task RemoveAsync(long id)
    {
        var model = await _dbSet.SingleOrDefaultAsync(x => x.Id == id);

        await RemoveAsync(model);
    }
}