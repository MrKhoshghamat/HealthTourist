using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
{
    public void Configure(EntityTypeBuilder<AboutUs> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(AboutUsConfigurationConstants.TitleMaxLength);
        builder.Property(a => a.Description)
            .IsRequired()
            .HasMaxLength(AboutUsConfigurationConstants.DescriptionMaximumLength);

        // Configure one-to-many relationship with AboutUsAttachment
        builder.HasMany(a => a.AboutUsAttachments)
            .WithOne()
            .HasForeignKey(aua => aua.AboutUsId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}