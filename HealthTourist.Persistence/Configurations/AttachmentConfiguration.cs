using HealthTourist.Common.Constants.Attachments;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
{
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.FileExtension)
            .IsRequired()
            .HasMaxLength(AttachmentConfigurationConstants.FileExtensionMaxLength);

        // Configure one-to-many relationship with PersonAttachment
        builder.HasMany(a => a.PersonAttachments)
            .WithOne(pa => pa.Attachment)
            .HasForeignKey(pa => pa.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}