using HealthTourist.Common.Constants.Main.Treatment;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Treatment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TreatmentConfigurationConstants.TableName, TreatmentConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(t => t.Id);

        // Configure properties
        builder.Property(t => t.TreatmentTypeId).IsRequired();
        builder.Property(t => t.Name).IsRequired().HasMaxLength(TreatmentConfigurationConstants.NameMaxLength)
            .HasColumnType(TreatmentConfigurationConstants.VarcharColumnType);
        builder.Property(t => t.Title).IsRequired().HasMaxLength(TreatmentConfigurationConstants.TitleMaxLength)
            .HasColumnType(TreatmentConfigurationConstants.NVarcharColumnType);

        // Configure indexes
        builder.HasIndex(t => t.Name).IsClustered(false).IsUnique(false)
            .HasName(TreatmentConfigurationConstants.NameIndex);
        builder.HasIndex(t => t.Name).IsClustered(false).IsUnique(false)
            .HasName(TreatmentConfigurationConstants.TitleIndex);
        
        // Configure relationships
        builder.HasOne(t => t.TreatmentType)
            .WithMany(tt => tt.Treatments)
            .HasForeignKey(t => t.TreatmentTypeId);

        builder.HasMany(t => t.Doctors)
            .WithOne(d => d.Treatment)
            .HasForeignKey(d => d.TreatmentId);

        builder.HasMany(t => t.TeamMembers)
            .WithOne(tm => tm.Treatment)
            .HasForeignKey(tm => tm.TreatmentId);

        builder.HasMany(t => t.Triages)
            .WithOne(tr => tr.Treatment)
            .HasForeignKey(tr => tr.TreatmentId);
    }
}