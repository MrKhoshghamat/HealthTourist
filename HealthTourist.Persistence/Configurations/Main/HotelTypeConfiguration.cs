using HealthTourist.Common.Constants.Main.HotelType;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HotelTypeConfiguration : IEntityTypeConfiguration<HotelType>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<HotelType> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelTypeConfigurationConstants.TableName, HotelTypeConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(ht => ht.Id);

        // Configure properties
        builder.Property(ht => ht.Name).IsRequired().HasMaxLength(HotelTypeConfigurationConstants.NameMaxLength);
        builder.Property(ht => ht.Title).IsRequired().HasMaxLength(HotelTypeConfigurationConstants.TitleMaxLength);

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false)
            .HasName(HotelTypeConfigurationConstants.NameIndex);
        builder.HasIndex(a => a.Title).IsClustered(false)
            .HasName(HotelTypeConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(ht => ht.HotelRanks)
            .WithOne(hr => hr.HotelType)
            .HasForeignKey(hr => hr.HotelTypeId);
    }
}