using HealthTourist.Common.Constants.Locations;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Name)
            .IsRequired()
            .HasMaxLength(LocationConfigurationConstants.NameMaxLength);
        builder.Property(l => l.Title)
            .IsRequired()
            .HasMaxLength(LocationConfigurationConstants.TitleMaxLength);
        builder.Property(l => l.Latitude)
            .HasMaxLength(LocationConfigurationConstants.Latitude);
        builder.Property(l => l.Longitude)
            .HasMaxLength(LocationConfigurationConstants.LongitudeMaxLength);
    }
}