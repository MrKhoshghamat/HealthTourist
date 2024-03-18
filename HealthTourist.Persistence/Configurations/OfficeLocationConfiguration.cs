using HealthTourist.Common.Constants.OfficeLocations;
using HealthTourist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class OfficeLocationConfiguration : IEntityTypeConfiguration<OfficeLocation>
{
    public void Configure(EntityTypeBuilder<OfficeLocation> builder)
    {
        builder.ToTable(OfficeLocationConfigurationConstants.TableName,
            OfficeLocationConfigurationConstants.SchemaName);
        
        builder.HasKey(ol => new { ol.OfficeId, ol.LocationId });

        builder.HasOne(ol => ol.Office)
            .WithMany(o => o.OfficeLocations)
            .HasForeignKey(ol => ol.OfficeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ol => ol.Location)
            .WithMany(l => l.OfficeLocations)
            .HasForeignKey(ol => ol.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}