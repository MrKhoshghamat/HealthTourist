using HealthTourist.Common.Constants.Main.Patient;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        // Configure table name and schema name
        builder.ToTable(PatientConfigurationConstants.TableName, PatientConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(p => p.Id);

        // Configure properties
        builder.Property(p => p.PersonId).IsRequired();
        builder.Property(p => p.Height).HasMaxLength(PatientConfigurationConstants.HeightMaxLength);
        builder.Property(p => p.Weight).HasMaxLength(PatientConfigurationConstants.WeightMaxLength);

        // Configure relationships
        builder.HasOne(p => p.Person)
            .WithOne(p=>p.Patient)
            .HasForeignKey<Patient>(p => p.PersonId);

        builder.HasMany(p => p.Travels)
            .WithOne(t => t.Patient)
            .HasForeignKey(t => t.PatientId);

        builder.HasMany(p => p.Triages)
            .WithOne(tg => tg.Patient)
            .HasForeignKey(tg => tg.PatientId);
    }
}