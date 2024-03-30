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
        builder.Property(c => c.Name).IsRequired().HasMaxLength(CategoryConfigurationConstants.NameMaxLength)
            .HasColumnType(CategoryConfigurationConstants.VarcharColumnType);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(CategoryConfigurationConstants.TitleMaxLength)
            .HasColumnType(CategoryConfigurationConstants.NVarcharColumnType);

        // Configure indexes
        builder.HasIndex(c => c.Name).IsClustered(false).IsUnique(false)
            .HasName(CategoryConfigurationConstants.NameIndex);

        // Configure relationships
        builder.HasMany(c => c.SightseenCategories)
            .WithOne(sc => sc.Category)
            .HasForeignKey(sc => sc.CategoryId);
    }
}