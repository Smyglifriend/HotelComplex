using HotelComplex.DataAccess.Abstractions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HotelComplex.DataAccess;

public class ClientsDbContext : DbContext
 {
     public ClientsDbContext(
         DbContextOptions<ClientsDbContext> options) : base(options)
     {
         //Database.EnsureCreated();
     }
 
     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
         modelBuilder.ApplyClientConfigurations();
     }
 }