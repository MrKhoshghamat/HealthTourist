using HealthTourist.Common.Constants.Main.Sightseen;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class SightseenConfiguration : IEntityTypeConfiguration<Sightseen>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Sightseen> builder)
    {
        // Configure table name and schema name
        builder.ToTable(SightseenConfigurationConstants.TableName, SightseenConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(s => s.Id);

        // Configure properties
        builder.Property(s => s.CityId).IsRequired();
        builder.Property(s => s.Name).IsRequired().HasMaxLength(SightseenConfigurationConstants.NameMaxLength)
            .HasColumnType(SightseenConfigurationConstants.VarcharColumnType);
        builder.Property(s => s.Title).IsRequired().HasMaxLength(SightseenConfigurationConstants.TitleMaxLength)
            .HasColumnType(SightseenConfigurationConstants.NVarcharColumnType);
        builder.Property(s => s.Lat).IsRequired();
        builder.Property(s => s.Long).IsRequired();

        // Configure indexes
        builder.HasIndex(s => s.Name).IsClustered(false).IsUnique(false)
            .HasName(SightseenConfigurationConstants.NameIndex);
        builder.HasIndex(s => s.Title).IsClustered(false).IsUnique(false)
            .HasName(SightseenConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasOne(s => s.City)
            .WithMany()
            .HasForeignKey(s => s.CityId);

        builder.HasMany(s => s.SightseenAttachments)
            .WithOne(sa => sa.Sightseen)
            .HasForeignKey(sa => sa.SightseenId);

        builder.HasMany(s => s.SightseenCategories)
            .WithOne(sc => sc.Sightseen)
            .HasForeignKey(sc => sc.SightseenId);
    }
}