using System.Reflection;
using HotelComplex.CQRS.Abstractions.Extensions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HotelComplex.CQRS.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCqrs(this IServiceCollection services)
        => services
            .AddCqrsMapper()
            .AddMediatrCqrs();

    private static IServiceCollection AddMediatrCqrs(this IServiceCollection services)
        => services.AddMediatR(Assembly.GetExecutingAssembly());
}