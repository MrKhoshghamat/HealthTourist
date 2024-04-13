using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class CityAttachmentConfiguration : IEntityTypeConfiguration<CityAttachment>
{
    public void Configure(EntityTypeBuilder<CityAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(CityAttachmentConfigurationConstants.TableName,
            CityAttachmentConfigurationConstants.SchemaName);

        // Configure composite primary key
        builder.HasKey(ca => new { ca.CityId, ca.AttachmentId });

        // Configure relations
        builder.HasOne(ca => ca.City)
            .WithMany(c => c.CityAttachments)
            .HasForeignKey(ca => ca.CityId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ca => ca.Attachment)
            .WithMany(a => a.CityAttachments)
            .HasForeignKey(ca => ca.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}