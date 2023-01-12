using System.Reflection;
using MassTransit;
using MediatR;

namespace RabbitMQ.Consumers.Extensions;

public static class BusRegistrationConfiguratorExtension 
{
    public static void AddConsumersRabbitMq(this IBusRegistrationConfigurator services)
    {
         services.AddConsumers(Assembly.GetExecutingAssembly());
    }
}