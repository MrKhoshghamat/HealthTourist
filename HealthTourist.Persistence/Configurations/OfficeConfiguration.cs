using HealthTourist.Common.Constants.Office;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(o => o.Name).IsRequired().HasMaxLength(OfficeConfigurationConstants.NameMaxLength);
        builder.Property(o => o.Title).IsRequired().HasMaxLength(OfficeConfigurationConstants.TitleMaxLength);
        builder.Property(o => o.PhoneNumber1).HasMaxLength(OfficeConfigurationConstants.PhoneNumber1MaxLength);
        builder.Property(o => o.PhoneNumber2).HasMaxLength(OfficeConfigurationConstants.PhoneNumber2MaxLength);
        builder.Property(o => o.PhoneNumber3).HasMaxLength(OfficeConfigurationConstants.PhoneNumber3MaxLength);
        builder.Property(o => o.FaxNumber).HasMaxLength(OfficeConfigurationConstants.FaxNumberMaxLength);
        builder.Property(o => o.Email).HasMaxLength(OfficeConfigurationConstants.EmailMaxLength);
        builder.Property(o => o.Address).IsRequired();
        builder.Property(o => o.PostalCode).HasMaxLength(OfficeConfigurationConstants.PostalCodeMaxLength);

        // Configure many-to-many relationship with Location
        builder.HasMany(o => o.OfficeLocations)
            .WithOne(ol => ol.Office)
            .HasForeignKey(ol => ol.OfficeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}