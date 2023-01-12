using HotelComplex.DataAccess.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelComplex.DataAccess.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUserDataAccess(this IServiceCollection services, IConfiguration configuration)
        => services
            .AddDbContext<ClientsDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
            .AddUnitOfWork<ClientsDbContext>();
}