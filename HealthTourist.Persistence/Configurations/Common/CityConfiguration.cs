using HealthTourist.Common.Constants.Common.City;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Common;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<City> builder)
    {
        // Configure table name and schema name
        builder.ToTable(CityConfigurationConstants.TableName, CityConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(c => c.Id);

        // Configure properties
        builder.Property(c => c.Name).IsRequired().HasMaxLength(CityConfigurationConstants.NameMaxlength);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(CityConfigurationConstants.TitleMaxlength);

        // Configure indexes
        builder.HasIndex(c => c.Name).IsClustered(false)
            .HasName(CityConfigurationConstants.NameIndex);

        // Configure relationships
        builder.HasOne(c => c.State)
            .WithMany(s => s.Cities)
            .HasForeignKey(c => c.StateId)
            .IsRequired();

        builder.HasMany(c => c.Hospitals)
            .WithOne(h => h.City)
            .HasForeignKey(h => h.CityId);

        builder.HasMany(c => c.Hotels)
            .WithOne(h => h.City)
            .HasForeignKey(h => h.CityId);

        builder.HasMany(c => c.Offices)
            .WithOne(o => o.City)
            .HasForeignKey(o => o.CityId);

        builder.HasMany(c => c.Sightseens)
            .WithOne(s => s.City)
            .HasForeignKey(s => s.CityId);
        
        builder.HasMany(c => c.CityAttachments)
            .WithOne(ca => ca.City)
            .HasForeignKey(ca => ca.CityId);
    }
}