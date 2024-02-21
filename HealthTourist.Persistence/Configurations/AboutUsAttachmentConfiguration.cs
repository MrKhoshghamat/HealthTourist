using HealthTourist.Common.Constants.AboutUsAttachments;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsAttachmentConfiguration : IEntityTypeConfiguration<AboutUsAttachment>
{
    public void Configure(EntityTypeBuilder<AboutUsAttachment> builder)
    {
        builder.ToTable(AboutUsAttachmentConfigurationConstants.TableName,
            AboutUsAttachmentConfigurationConstants.SchemaName);
        
        builder.HasKey(aua => new { aua.AboutUsId, aua.AttachmentId });

        builder.HasOne(aua => aua.AboutUs)
            .WithMany(au => au.AboutUsAttachments)
            .HasForeignKey(aua => aua.AboutUsId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(aua => aua.Attachment)
            .WithMany(au=> au.AboutUsAttachments)
            .HasForeignKey(aua => aua.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}