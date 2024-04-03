using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HospitalTagConfiguration : IEntityTypeConfiguration<HospitalTag>
{
    public void Configure(EntityTypeBuilder<HospitalTag> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HospitalTagConfigurationConstants.TableName,
            HospitalTagConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(ht => new { ht.HospitalId, ht.TagId });

        // Configure relations
        builder.HasOne(ht => ht.Hospital)
            .WithMany(h => h.HospitalTags)
            .HasForeignKey(ht => ht.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ht => ht.Tag)
            .WithMany(t => t.HospitalTags)
            .HasForeignKey(ht => ht.TagId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}