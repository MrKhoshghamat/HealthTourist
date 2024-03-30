using HealthTourist.Common.Constants.Main.HospitalType;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HospitalTypeConfiguration : IEntityTypeConfiguration<HospitalType>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<HospitalType> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HospitalTypeConfigurationConstants.TableName, HospitalTypeConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(ht => ht.Id);

        // Configure properties
        builder.Property(ht => ht.Name).IsRequired().HasMaxLength(HospitalTypeConfigurationConstants.NameMaxLength)
            .HasColumnType(HospitalTypeConfigurationConstants.VarcharColumnType);
        builder.Property(ht => ht.Title).IsRequired().HasMaxLength(HospitalTypeConfigurationConstants.TitleMaxLength)
            .HasColumnType(HospitalTypeConfigurationConstants.NVarcharColumnType);

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false).IsUnique(false)
            .HasName(HospitalTypeConfigurationConstants.NameIndex);
        builder.HasIndex(a => a.Title).IsClustered(false).IsUnique(false)
            .HasName(HospitalTypeConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(ht => ht.Hospitals)
            .WithOne(h => h.HospitalType)
            .HasForeignKey(h => h.HospitalTypeId);
    }
}