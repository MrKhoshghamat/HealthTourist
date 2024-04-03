using HealthTourist.Common.Constants.Main.Health;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HealthConfiguration : IEntityTypeConfiguration<Health>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Health> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HealthConfigurationConstants.TableName, HealthConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(h => h.Id);

        // Configure properties
        builder.Property(h => h.TriageNo).IsRequired();
        builder.Property(h => h.HospitalId).IsRequired();
        builder.Property(h => h.DoctorId).IsRequired();
        builder.Property(h => h.Cost).IsRequired()
            .HasMaxLength(HealthConfigurationConstants.CostMaxLength); // Adjust the length as per your needs

        // Configure indexes
        builder.HasIndex(h => h.TriageNo).IsClustered(false)
            .HasName(HealthConfigurationConstants.TriageNoIndex);

        // Configure relationships
        builder.HasOne(h => h.Hospital)
            .WithMany()
            .HasForeignKey(h => h.HospitalId);

        builder.HasOne(h => h.Doctor)
            .WithMany()
            .HasForeignKey(h => h.DoctorId);

        builder.HasMany(h => h.HealthCosts)
            .WithOne(hc => hc.Health)
            .HasForeignKey(hc => hc.HealthId);

        builder.HasMany(h => h.Invoices)
            .WithOne(i => i.Health)
            .HasForeignKey(i => i.HealthId);

        builder.HasMany(h => h.HealthAttachments)
            .WithOne(ha => ha.Health)
            .HasForeignKey(ha => ha.HealthId);
    }
}