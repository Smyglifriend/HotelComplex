using System.Reflection;

namespace HotelComplex.Clients.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
        => services
            .AddAutoMapper(Assembly.GetExecutingAssembly());
}