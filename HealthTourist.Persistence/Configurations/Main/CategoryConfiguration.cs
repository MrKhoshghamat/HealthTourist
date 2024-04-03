using HealthTourist.Common.Constants.Main.Category;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // Configure table name and schema name
        builder.ToTable(CategoryConfigurationConstants.TableName, CategoryConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(c => c.Id);

        // Configure properties
        builder.Property(c => c.Name).IsRequired().HasMaxLength(CategoryConfigurationConstants.NameMaxLength);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(CategoryConfigurationConstants.TitleMaxLength);

        // Configure indexes
        builder.HasIndex(c => c.Name).IsClustered(false)
            .HasName(CategoryConfigurationConstants.NameIndex);
        builder.HasIndex(c => c.Title).IsClustered(false)
            .HasName(CategoryConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(c => c.SightseenCategories)
            .WithOne(sc => sc.Category)
            .HasForeignKey(sc => sc.CategoryId);
    }
}