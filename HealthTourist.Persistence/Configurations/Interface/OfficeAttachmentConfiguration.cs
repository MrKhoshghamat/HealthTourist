using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class OfficeAttachmentConfiguration : IEntityTypeConfiguration<OfficeAttachment>
{
    public void Configure(EntityTypeBuilder<OfficeAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(OfficeAttachmentConfigurationConstants.TableName,
            OfficeAttachmentConfigurationConstants.SchemaName);

        // Configure composite primary key if needed
        builder.HasKey(oa => new { oa.OfficeId, oa.AttachmentId });

        // Configure relations
        builder.HasOne(oa => oa.Office)
            .WithMany(o => o.OfficeAttachments)
            .HasForeignKey(oa => oa.OfficeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(oa => oa.Attachment)
            .WithMany(a => a.OfficeAttachments)
            .HasForeignKey(oa => oa.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}