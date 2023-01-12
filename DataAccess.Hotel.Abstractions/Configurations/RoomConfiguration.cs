using DataAccess.Hotel.Abstractions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Hotel.Abstractions.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        
    }
}