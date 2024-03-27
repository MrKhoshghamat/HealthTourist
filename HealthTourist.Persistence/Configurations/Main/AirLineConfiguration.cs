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
        builder.Property(a => a.Name).IsRequired().HasMaxLength(AirLineConfigurationConstants.NameMaxLength)
            .HasColumnType("varchar");
        builder.Property(a => a.Title).IsRequired().HasMaxLength(AirLineConfigurationConstants.TitleMaxLength)
            .HasColumnType("nvarchar");

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false).IsUnique(false).HasName("IX_AirLine_Name");

        // Configure relationships
        builder.HasMany(a => a.Travels)
            .WithOne(t => t.AirLine)
            .HasForeignKey(t => t.AirLineId);
    }
}