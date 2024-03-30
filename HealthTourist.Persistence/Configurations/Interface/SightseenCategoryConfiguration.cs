using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class SightseenCategoryConfiguration : IEntityTypeConfiguration<SightseenCategory>
{
    public void Configure(EntityTypeBuilder<SightseenCategory> builder)
    {
        // Configure table name and schema name
        builder.ToTable(SightseenCategoryConfigurationConstants.TableName,
            SightseenCategoryConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(sc => new { sc.SightseenId, sc.CategoryId });

        // Configure relations
        builder.HasOne(sc => sc.Sightseen)
            .WithMany(s => s.SightseenCategories)
            .HasForeignKey(sc => sc.SightseenId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(sc => sc.Category)
            .WithMany(c => c.SightseenCategories)
            .HasForeignKey(sc => sc.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}