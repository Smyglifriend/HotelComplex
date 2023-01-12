using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace RabbitMQ.Consumers.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediatrRabbitMq(this IServiceCollection services)
        => services.AddMediatR(Assembly.GetExecutingAssembly());
}