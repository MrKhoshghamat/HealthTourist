using HealthTourist.Common.Constants.Persons;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable(PersonConfigurationConstants.TableName, PersonConfigurationConstants.SchemaName);
        
        builder.Property(x => x.CreatorId).IsRequired(false);
        builder.Property(x => x.ModifierId).IsRequired(false);
        builder.Property(x => x.RemoverId).IsRequired(false);
        
        builder.HasKey(p => p.Id);
        builder.Property(p => p.NationalCode)
            .HasMaxLength(PersonConfigurationConstants.NationalCodeMaxLength);
        builder.Property(p => p.FirstName)
            .IsRequired(false)
            .HasMaxLength(PersonConfigurationConstants.FirstNameMaxLength);
        builder.Property(p => p.LastName)
            .IsRequired(false)
            .HasMaxLength(PersonConfigurationConstants.LastNameMaxLength);
        builder.Property(p => p.PhoneNumber)
            .HasMaxLength(PersonConfigurationConstants.PhoneNumberMaxLength);
        builder.Property(p => p.Email)
            .HasMaxLength(PersonConfigurationConstants.EmailMaxLength);
        builder.Property(p => p.Address)
            .IsRequired(false);
        
        // Configure one-to-one relationship with TeamMember
        builder.HasOne(p => p.TeamMember)
            .WithOne(tm => tm.Person)
            .HasForeignKey<TeamMember>(tm => tm.PersonId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.PersonAttachments)
            .WithOne(pa => pa.Person)
            .HasForeignKey(pa => pa.PersonId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}