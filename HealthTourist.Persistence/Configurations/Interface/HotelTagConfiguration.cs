using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HotelTagConfiguration : IEntityTypeConfiguration<HotelTag>
{
    public void Configure(EntityTypeBuilder<HotelTag> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelTagConfigurationConstants.TableName,
            HotelTagConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(ht => new { ht.HotelId, ht.TagId });

        // Configure relations
        builder.HasOne(ht => ht.Hotel)
            .WithMany(h => h.HotelTags)
            .HasForeignKey(ht => ht.HotelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ht => ht.Tag)
            .WithMany(t => t.HotelTags)
            .HasForeignKey(ht => ht.TagId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}