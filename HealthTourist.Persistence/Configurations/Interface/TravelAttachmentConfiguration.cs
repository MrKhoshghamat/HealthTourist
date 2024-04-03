using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TravelAttachmentConfiguration : IEntityTypeConfiguration<TravelAttachment>
{
    public void Configure(EntityTypeBuilder<TravelAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TravelAttachmentConfigurationConstants.TableName,
            TravelAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(ta => new { ta.TravelId, ta.AttachmentId });

        // Configure relations
        builder.HasOne(ta => ta.Travel)
            .WithMany(t => t.TravelAttachments)
            .HasForeignKey(ta => ta.TravelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ta => ta.Attachment)
            .WithMany(a => a.TravelAttachments)
            .HasForeignKey(ta => ta.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}