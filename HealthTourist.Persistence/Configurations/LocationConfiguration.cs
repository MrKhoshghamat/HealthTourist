using HealthTourist.Common.Constants.Locations;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable(LocationConfigurationConstants.TableName, LocationConfigurationConstants.SchemaName);
        
        builder.Property(x => x.CreatorId).IsRequired(false);
        builder.Property(x => x.ModifierId).IsRequired(false);
        builder.Property(x => x.RemoverId).IsRequired(false);
        
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
        
        builder.HasMany(l=>l.OfficeLocations)
            .WithOne(ol=>ol.Location)
            .HasForeignKey(ol=>ol.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}