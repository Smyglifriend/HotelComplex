using HotelComplex.DataAccess.Shared.Abstractions.Interfaces;

namespace HotelComplex.DataAccess.Shared.Abstractions.Repositories;

public interface IBaseReadWriteRepository<TEntity> 
    : IBaseReadonlyRepository<TEntity>
    where TEntity : class, IEntity
{
    Task<long> SaveAsync(TEntity model);

    Task<TEntity> UpdateAsync(TEntity model);

    Task SaveChangesAsync();

    Task RemoveAsync(TEntity model);

    Task RemoveAsync(long id);
}