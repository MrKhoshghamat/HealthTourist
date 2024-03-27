using HealthTourist.Common.Constants.Main.FaqType;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class FaqTypeConfiguration : IEntityTypeConfiguration<FaqType>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<FaqType> builder)
    {
        // Configure table name and schema name
        builder.ToTable(FaqTypeConfigurationConstants.TableName, FaqTypeConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(ft => ft.Id);

        // Configure properties
        builder.Property(ft => ft.Name).IsRequired().HasMaxLength(FaqTypeConfigurationConstants.NameMaxLength)
            .HasColumnType("varchar");
        builder.Property(ft => ft.Title).IsRequired().HasMaxLength(FaqTypeConfigurationConstants.TitleMaxLength)
            .HasColumnType("nvarchar");
        builder.Property(ft => ft.Description).IsRequired()
            .HasMaxLength(FaqTypeConfigurationConstants.DescriptionMaxLength).HasColumnType("nvarchar");
        builder.Property(ft => ft.Priority).IsRequired();

        // Configure indexes
        builder.HasIndex(f => f.Name).IsClustered(false).IsUnique(false).HasName("IX_FaqType_Name");
        
        // Configure relationships
        builder.HasMany(ft => ft.Faqs)
            .WithOne(f => f.FaqType)
            .HasForeignKey(f => f.FaqTypeId);
    }
}