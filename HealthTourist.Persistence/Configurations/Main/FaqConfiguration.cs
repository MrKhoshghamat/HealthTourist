using HealthTourist.Common.Constants.Main.Faq;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class FaqConfiguration : IEntityTypeConfiguration<Faq>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Faq> builder)
    {
        // Configure table name and schema name
        builder.ToTable(FaqConfigurationConstants.TableName, FaqConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(f => f.Id);

        // Configure properties
        builder.Property(f => f.FaqTypeId).IsRequired();
        builder.Property(f => f.Name).IsRequired().HasMaxLength(FaqConfigurationConstants.NameMaxLength)
            .HasColumnType(FaqConfigurationConstants.VarcharColumnType);
        builder.Property(f => f.Title).IsRequired().HasMaxLength(FaqConfigurationConstants.TitleMaxLength)
            .HasColumnType(FaqConfigurationConstants.NVarcharColumnType);
        builder.Property(f => f.Description).IsRequired().HasMaxLength(FaqConfigurationConstants.DescriptionMaxLength)
            .HasColumnType(FaqConfigurationConstants.NVarcharColumnType);
        builder.Property(f => f.Priority).IsRequired();
        builder.Property(f => f.IsFirstPage).IsRequired();

        // Configure indexes
        builder.HasIndex(f => f.Name).IsClustered(false).IsUnique(false).HasName(FaqConfigurationConstants.NameIndex);
        builder.HasIndex(f => f.Name).IsClustered(false).IsUnique(false).HasName(FaqConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasOne(f => f.FaqType)
            .WithMany()
            .HasForeignKey(f => f.FaqTypeId);
    }
}