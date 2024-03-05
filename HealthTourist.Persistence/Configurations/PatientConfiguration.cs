using HealthTourist.Common.Constants.Departments;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Department;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.ToTable(PatientConfigurationConstants.TableName, PatientConfigurationConstants.SchemaName);

        builder.HasKey(pa => pa.Id);

        builder.Property(pa => pa.Height)
            .HasMaxLength(PatientConfigurationConstants.HeightMaximumLength)
            .IsRequired();

        builder.Property(pa => pa.Weight)
            .HasMaxLength(PatientConfigurationConstants.WeightMaximumLength)
            .IsRequired();

        builder.HasOne(pa => pa.Person)
            .WithOne(p => p.Patient)
            .HasForeignKey<Patient>(pa => pa.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(pa => pa.PatientAttachments)
            .WithOne(paa => paa.Patient)
            .HasForeignKey(paa => paa.PatientId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}