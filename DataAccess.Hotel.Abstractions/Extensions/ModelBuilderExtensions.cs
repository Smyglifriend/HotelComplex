using DataAccess.Hotel.Abstractions.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Hotel.Abstractions.Extensions;

public static class ModelBuilderExtensions
{
    public static ModelBuilder ApplyRoomConfigurations(this ModelBuilder builder)
        => builder.ApplyConfiguration(new RoomConfiguration());
}