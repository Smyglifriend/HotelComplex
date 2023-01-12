using HotelComplex.Clients.Extensions;
using HotelComplex.CQRS.Extensions;
using HotelComplex.DataAccess.Extensions;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUserDataAccess(builder.Configuration)
    .AddMapper()
    .AddCqrs()
    .AddMassTransit(x =>
    {
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