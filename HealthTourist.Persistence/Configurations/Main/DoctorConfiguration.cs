using HealthTourist.Common.Constants.Main.Doctor;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        // Configure table name and schema name
        builder.ToTable(DoctorConfigurationConstants.TableName, DoctorConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(d => d.Id);

        // Configure properties
        builder.Property(d => d.PersonId).IsRequired();
        builder.Property(d => d.HospitalId).IsRequired();
        builder.Property(d => d.TreatmentId).IsRequired();

        // Configure relationships
        builder.HasOne(d => d.Person)
            .WithMany()
            .HasForeignKey(d => d.PersonId);

        builder.HasOne(d => d.Hospital)
            .WithMany()
            .HasForeignKey(d => d.HospitalId);

        builder.HasOne(d => d.Treatment)
            .WithMany()
            .HasForeignKey(d => d.TreatmentId);

        builder.HasMany(d => d.Healths)
            .WithOne(h => h.Doctor)
            .HasForeignKey(h => h.DoctorId);

        builder.HasMany(d => d.TeamMembers)
            .WithOne(tm => tm.Doctor)
            .HasForeignKey(tm => tm.DoctorId);
    }
}