using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(opt => opt
    .AddPolicy("HotelComplexPolicy", policy =>
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()));

builder.Configuration.AddJsonFile("ocelot.Local.json", false, true);
builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("HotelComplexPolicy");
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

await app.UseOcelot();
app.MapControllers();

app.Run();