using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HospitalAttachmentConfiguration : IEntityTypeConfiguration<HospitalAttachment>
{
    public void Configure(EntityTypeBuilder<HospitalAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HospitalAttachmentConfigurationConstants.TableName,
            HospitalAttachmentConfigurationConstants.SchemaName);

        // Configure composite primary key
        builder.HasKey(ha => new { ha.HospitalId, ha.AttachmentId });

        // Configure relations
        builder.HasOne(ha => ha.Hospital)
            .WithMany(h => h.HospitalAttachments)
            .HasForeignKey(ha => ha.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ha => ha.Attachment)
            .WithMany(a => a.HospitalAttachments)
            .HasForeignKey(ha => ha.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}