using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
{
    public void Configure(EntityTypeBuilder<AboutUs> builder)
    {
        builder.ToTable(AboutUsConfigurationConstants.TableName, AboutUsConfigurationConstants.SchemaName);

        builder.Property(x => x.CreatorId).IsRequired(false);
        builder.Property(x => x.ModifierId).IsRequired(false);
        builder.Property(x => x.RemoverId).IsRequired(false);
        
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Title)
            .IsRequired()
            .HasMaxLength(AboutUsConfigurationConstants.TitleMaxLength);
        builder.Property(a => a.Description)
            .IsRequired()
            .HasMaxLength(AboutUsConfigurationConstants.DescriptionMaximumLength);

        // Configure one-to-many relationship with AboutUsAttachment
        builder.HasMany(a => a.AboutUsAttachments)
            .WithOne(au=>au.AboutUs)
            .HasForeignKey(aua => aua.AboutUsId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.AboutUsOffices)
            .WithOne(auo => auo.AboutUs)
            .HasForeignKey(auo => auo.AboutUsId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.AboutUsTeamMembers)
            .WithOne(atm => atm.AboutUs)
            .HasForeignKey(atm => atm.AboutUsId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}