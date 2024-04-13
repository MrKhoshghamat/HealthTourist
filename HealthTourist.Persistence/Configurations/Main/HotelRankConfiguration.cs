using HealthTourist.Common.Constants.Main.HotelRank;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HotelRankConfiguration : IEntityTypeConfiguration<HotelRank>
{
    public void Configure(EntityTypeBuilder<HotelRank> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelRankConfigurationConstants.TableName, HotelRankConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(hr => hr.Id);

        // Configure properties
        builder.Property(hr => hr.HotelTypeId).IsRequired();
        builder.Property(hr => hr.Title).IsRequired().HasMaxLength(HotelRankConfigurationConstants.TitleMaxLength);

        // Configure relationships
        builder.HasOne(hr => hr.HotelType)
            .WithMany()
            .HasForeignKey(hr => hr.HotelTypeId);

        builder.HasMany(hr => hr.Hotels)
            .WithOne(h => h.HotelRank)
            .HasForeignKey(h => h.HotelRankId);
    }
}