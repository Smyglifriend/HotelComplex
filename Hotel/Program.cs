using System.Reflection;
using DataAccess.Hotel.Extensions;
using HotelComplex.CQRS.Extensions;
using HotelComplex.Hotel.Extensions;
using MassTransit;
using RabbitMQ.Consumers.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddHotelDataAccess(builder.Configuration)
    .AddMapper()
    .AddMediatrRabbitMq()
    .AddCqrs()
    .AddMassTransit(x =>
    {
        x.AddConsumersRabbitMq();
        x.UsingRabbitMq((context, cfg) =>
        {
            cfg.Host("localhost", "/", h =>
            {
                h.Username("guest");
                h.Password("guest");
            });
            cfg.ConfigureEndpoints(context);
        });
    })
    .AddControllers()
    .Services.AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();