using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HotelAttachmentConfiguration : IEntityTypeConfiguration<HotelAttachment>
{
    public void Configure(EntityTypeBuilder<HotelAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelAttachmentConfigurationConstants.TableName,
            HotelAttachmentConfigurationConstants.SchemaName);

        // Configure composite primary key if needed
        builder.HasKey(ha => new { ha.HotelId, ha.AttachmentId });

        // Configure relations
        builder.HasOne(ha => ha.Hotel)
            .WithMany(h => h.HotelAttachments)
            .HasForeignKey(ha => ha.HotelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ha => ha.Attachment)
            .WithMany(a => a.HotelAttachments)
            .HasForeignKey(ha => ha.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}