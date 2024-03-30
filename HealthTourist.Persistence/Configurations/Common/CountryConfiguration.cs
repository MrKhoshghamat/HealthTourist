using HealthTourist.Common.Constants.Common.Country;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Common;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        // Configure table name and schema name
        builder.ToTable(CountryConfigurationConstants.TableName, CountryConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(c => c.Id);

        // Configure properties
        builder.Property(c => c.Name).IsRequired().HasMaxLength(CountryConfigurationConstants.NameMaxLength)
            .HasColumnType(CountryConfigurationConstants.VarcharColumnType);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(CountryConfigurationConstants.TitleMaxLength)
            .HasColumnType(CountryConfigurationConstants.NVarcharColumnType);
        builder.Property(c => c.Code).IsRequired().HasMaxLength(CountryConfigurationConstants.CodeMaxLength)
            .HasColumnType(CountryConfigurationConstants.VarcharColumnType);

        // Configure indexes
        builder.HasIndex(c => c.Name).IsClustered(false).IsUnique(false)
            .HasName(CountryConfigurationConstants.NameIndex);
        builder.HasIndex(c => c.Title).IsClustered(false).IsUnique(false)
            .HasName(CountryConfigurationConstants.TitleIndex);
        builder.HasIndex(c => c.Code).IsClustered(false).IsUnique(false)
            .HasName(CountryConfigurationConstants.CodeIndex);

        // Configure relationships
        builder.HasMany(c => c.States)
            .WithOne(s => s.Country)
            .HasForeignKey(s => s.CountryId);

        builder.HasMany(c => c.Offices)
            .WithOne(o => o.Country)
            .HasForeignKey(o => o.CountryId);
    }
}