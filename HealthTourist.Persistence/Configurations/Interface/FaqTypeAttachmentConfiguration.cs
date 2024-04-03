using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class FaqTypeAttachmentConfiguration : IEntityTypeConfiguration<FaqTypeAttachment>
{
    public void Configure(EntityTypeBuilder<FaqTypeAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(FaqTypeAttachmentConfigurationConstants.TableName, FaqTypeAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key
        builder.HasKey(fta => new { fta.FaqTypeId, fta.AttachmentId });

        // Configure relations
        builder.HasOne(fta => fta.FaqType)
            .WithMany(ft => ft.FaqTypeAttachments)
            .HasForeignKey(fta => fta.FaqTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(fta => fta.Attachment)
            .WithMany(a => a.FaqTypeAttachments)
            .HasForeignKey(fta => fta.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}