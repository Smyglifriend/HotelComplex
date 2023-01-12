using HotelComplex.DataAccess.Abstractions.Configurations;
using Microsoft.EntityFrameworkCore;

namespace HotelComplex.DataAccess.Abstractions.Extensions;

public static class ModelBuilderExtensions
{
    public static ModelBuilder ApplyClientConfigurations(this ModelBuilder builder)
        => builder.ApplyConfiguration(new ClientConfiguration());
}