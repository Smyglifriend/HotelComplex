using HotelComplex.DataAccess.Shared.Abstractions.Repositories;
using HotelComplex.DataAccess.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelComplex.DataAccess.Shared.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services)
        where TContext : DbContext
        => services
            .AddScoped<IUnitOfWork, UnitOfWork<TContext>>();

    public static IServiceCollection AddCustomRepository<TEntity, TIRepository, TRepository>(
        this IServiceCollection services)
        where TEntity : class
        where TIRepository : class, IBaseReadonlyRepository<TEntity>
        where TRepository : class, TIRepository
        => services
            .AddScoped<TIRepository, TRepository>();
}