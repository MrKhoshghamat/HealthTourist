using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TriageAttachmentConfiguration : IEntityTypeConfiguration<TriageAttachment>
{
    public void Configure(EntityTypeBuilder<TriageAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TriageAttachmentConfigurationConstants.TableName,
            TriageAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(ta => new { ta.TriageId, ta.AttachmentId });

        // Configure relations
        builder.HasOne(ta => ta.Triage)
            .WithMany(t => t.TriageAttachments)
            .HasForeignKey(ta => ta.TriageId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ta => ta.Attachment)
            .WithMany(a => a.TriageAttachments)
            .HasForeignKey(ta => ta.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}