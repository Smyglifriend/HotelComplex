using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace HotelComplex.CQRS.Abstractions.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCqrsMapper(this IServiceCollection services)
        => services.AddAutoMapper(Assembly.GetExecutingAssembly());
}