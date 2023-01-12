using HotelComplex.DataAccess.Shared.Abstractions.Interfaces;

namespace HotelComplex.DataAccess.Shared.Abstractions.Repositories;

public interface IUnitOfWork : IDisposable
{
    IBaseReadonlyRepository<TEntity> GetReadonlyRepository<TEntity>() 
        where TEntity : class;
        
    IBaseReadWriteRepository<TEntity> GetReadWriteRepository<TEntity>() 
        where TEntity : class, IEntity;

    TIRepository GetCustomRepository<TEntity, TIRepository>()
        where TEntity : class
        where TIRepository : class, IBaseReadonlyRepository<TEntity>;

    Task<int> SaveChangesAsync();

    int ExecuteSqlCommand(
        string sql, 
        params object[] parameters);

    IQueryable<TEntity> FromSql<TEntity>(
        string sql, 
        params object[] parameters) 
        where TEntity : class;
}