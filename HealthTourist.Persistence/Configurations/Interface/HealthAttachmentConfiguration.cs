using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HealthAttachmentConfiguration : IEntityTypeConfiguration<HealthAttachment>
{
    public void Configure(EntityTypeBuilder<HealthAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HealthAttachmentConfigurationConstants.TableName, HealthAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key
        builder.HasKey(ha => new { ha.HealthId, ha.AttachmentId });

        // Configure relations
        builder.HasOne(ha => ha.Health)
            .WithMany(h => h.HealthAttachments)
            .HasForeignKey(ha => ha.HealthId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ha => ha.Attachment)
            .WithMany(a => a.HealthAttachments)
            .HasForeignKey(ha => ha.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}