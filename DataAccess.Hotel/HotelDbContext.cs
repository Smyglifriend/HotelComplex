using DataAccess.Hotel.Abstractions.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Hotel;

public class HotelDbContext : DbContext
 {
     public HotelDbContext(
         DbContextOptions<HotelDbContext> options) : base(options)
     {
         //Database.EnsureCreated();
     }
 
     protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
         modelBuilder.ApplyRoomConfigurations();
     }
 }