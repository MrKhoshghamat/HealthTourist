using HealthTourist.Common.Constants.Main.AirLine;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class AirLineConfiguration : IEntityTypeConfiguration<AirLine>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<AirLine> builder)
    {
        // Configure table name and schema name
        builder.ToTable(AirLineConfigurationConstants.TableName, AirLineConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(a => a.Id);

        // Configure properties
        builder.Property(a => a.Name).IsRequired().HasMaxLength(AirLineConfigurationConstants.NameMaxLength);
        builder.Property(a => a.Title).IsRequired().HasMaxLength(AirLineConfigurationConstants.TitleMaxLength);

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false)
            .HasName(AirLineConfigurationConstants.NameIndex);
        builder.HasIndex(a => a.Title).IsClustered(false)
            .HasName(AirLineConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(a => a.Travels)
            .WithOne(t => t.AirLine)
            .HasForeignKey(t => t.AirLineId);
    }
}