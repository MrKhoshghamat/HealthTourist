using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TreatmentTypeAttachmentConfiguration : IEntityTypeConfiguration<TreatmentTypeAttachment>
{
    public void Configure(EntityTypeBuilder<TreatmentTypeAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TreatmentTypeAttachmentConfigurationConstants.TableName, TreatmentTypeAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key
        builder.HasKey(tta => new { tta.TreatmentTypeId, tta.AttachmentId });

        // Configure relations
        builder.HasOne(tta => tta.TreatmentType)
            .WithMany(tt => tt.TreatmentTypeAttachments)
            .HasForeignKey(tta => tta.TreatmentTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(tta => tta.Attachment)
            .WithMany(a => a.TreatmentTypeAttachments)
            .HasForeignKey(tta => tta.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}