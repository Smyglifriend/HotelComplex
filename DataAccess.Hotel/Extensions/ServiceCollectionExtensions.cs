using HotelComplex.DataAccess.Shared.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Hotel.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHotelDataAccess(this IServiceCollection services, IConfiguration configuration)
        => services
            .AddDbContext<HotelDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
            .AddUnitOfWork<HotelDbContext>();
}