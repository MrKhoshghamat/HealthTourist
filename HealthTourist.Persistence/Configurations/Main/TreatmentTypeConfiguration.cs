using HealthTourist.Common.Constants.Main.TreatmentType;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TreatmentTypeConfiguration : IEntityTypeConfiguration<TreatmentType>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<TreatmentType> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TreatmentTypeConfigurationConstants.TableName, TreatmentTypeConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(tt => tt.Id);

        // Configure properties
        builder.Property(tt => tt.Name).IsRequired().HasMaxLength(TreatmentTypeConfigurationConstants.NameMaxLength);
        builder.Property(tt => tt.Title).IsRequired().HasMaxLength(TreatmentTypeConfigurationConstants.TitleMaxLength);

        // Configure indexes
        builder.HasIndex(tt => tt.Name).IsClustered(false)
            .HasName(TreatmentTypeConfigurationConstants.NameIndex);
        builder.HasIndex(tt => tt.Name).IsClustered(false)
            .HasName(TreatmentTypeConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(tt => tt.Treatments)
            .WithOne(t => t.TreatmentType)
            .HasForeignKey(t => t.TreatmentTypeId);
    }
}