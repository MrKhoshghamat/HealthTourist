using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class SightseenAttachmentConfiguration : IEntityTypeConfiguration<SightseenAttachment>
{
    public void Configure(EntityTypeBuilder<SightseenAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(SightseenAttachmentConfigurationConstants.TableName,
            SightseenAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(sa => new { sa.SightseenId, sa.AttachmentId });

        // Configure relations
        builder.HasOne(sa => sa.Sightseen)
            .WithMany(s => s.SightseenAttachments)
            .HasForeignKey(sa => sa.SightseenId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(sa => sa.Attachment)
            .WithMany(a => a.SightseenAttachments)
            .HasForeignKey(sa => sa.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}