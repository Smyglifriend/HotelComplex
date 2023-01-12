using HotelComplex.DataAccess.Abstractions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelComplex.DataAccess.Abstractions.Configurations;

public class AccommodationConfiguration: IEntityTypeConfiguration<Accommodation>
{
    public void Configure(EntityTypeBuilder<Accommodation> builder)
    {
        builder
            .HasOne(a => a.Client)
            .WithMany(c => c.Accommodations)
            .HasForeignKey(a =>a.ClientId);
    }
}