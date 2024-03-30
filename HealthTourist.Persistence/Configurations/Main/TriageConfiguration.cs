using HealthTourist.Common.Constants.Main.Triage;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TriageConfiguration : IEntityTypeConfiguration<Triage>
{
    public void Configure(EntityTypeBuilder<Triage> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TriageConfigurationConstants.TableName, TriageConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(t => t.Id);

        // Configure properties
        builder.Property(t => t.TriageNo).IsRequired();
        builder.Property(t => t.PatientId).IsRequired();
        builder.Property(t => t.TreatmentId).IsRequired();
        builder.Property(t => t.Description).HasMaxLength(TriageConfigurationConstants.DescriptionMaxLength);

        // Configure relationships
        builder.HasOne(t => t.Patient)
            .WithMany(p => p.Triages)
            .HasForeignKey(t => t.PatientId);

        builder.HasOne(t => t.Treatment)
            .WithMany(t => t.Triages)
            .HasForeignKey(t => t.TreatmentId);

        builder.HasMany(t => t.TriageAttachments)
            .WithOne(ta => ta.Triage)
            .HasForeignKey(ta => ta.TriageId);
    }
}