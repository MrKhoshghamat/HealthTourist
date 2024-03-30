using HealthTourist.Common.Constants.Account;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Account;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        // Configure table name and schema name
        builder.ToTable(PersonConfigurationConstants.TableName, PersonConfigurationConstants.SchemaName);
        
        // Configure primary key
        builder.HasKey(p => p.Id);

        // Configure properties
        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(PersonConfigurationConstants.FirstNameMaxLength);
        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(PersonConfigurationConstants.LastNameMaxLength);
        builder.Property(p => p.BirthDate)
            .IsRequired();
        builder.Property(p => p.PhoneNumber)
            .HasMaxLength(PersonConfigurationConstants.PhoneNumberMaxLength);
        builder.Property(p => p.Email)
            .HasMaxLength(PersonConfigurationConstants.EmailMaxLength);
        builder.Property(p => p.Address)
            .HasMaxLength(PersonConfigurationConstants.AddressMaxLength);

        // Configure indexes
        builder.HasIndex(p => p.FirstName).IsClustered(false)
            .HasName(PersonConfigurationConstants.FirstNameIndex);
        builder.HasIndex(p => p.LastName).IsClustered(false)
            .HasName(PersonConfigurationConstants.LastNameIndex);
        builder.HasIndex(p => p.PhoneNumber).IsClustered(false)
            .HasName(PersonConfigurationConstants.PhoneNumberIndex);
        builder.HasIndex(p => p.Email).IsClustered(false)
            .HasName(PersonConfigurationConstants.EmailIndex);
        builder.HasIndex(p => p.Address).IsClustered(false)
            .HasName(PersonConfigurationConstants.AddressIndex);
        
        // Configure relations
        builder.HasOne(p => p.Doctor)
            .WithOne(d => d.Person)
            .HasForeignKey<Doctor>(d => d.PersonId);

        builder.HasOne(p => p.Guest)
            .WithOne(g => g.Person)
            .HasForeignKey<Guest>(g => g.PersonId);

        builder.HasOne(p => p.Patient)
            .WithOne(pt => pt.Person)
            .HasForeignKey<Patient>(pt => pt.PersonId);

        builder.HasOne(p => p.TeamMember)
            .WithOne(tm => tm.Person)
            .HasForeignKey<TeamMember>(tm => tm.PersonId);
        
        builder.HasOne(p => p.OfficeManager)
            .WithOne(om => om.Person)
            .HasForeignKey<OfficeManager>(om => om.PersonId);
    }
}