using System.Reflection;
using MediatR;

namespace HotelComplex.Hotel.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
        => services
            .AddAutoMapper(Assembly.GetExecutingAssembly());
}