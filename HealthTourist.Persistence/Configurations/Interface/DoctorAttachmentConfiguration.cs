using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class DoctorAttachmentConfiguration : IEntityTypeConfiguration<DoctorAttachment>
{
    public void Configure(EntityTypeBuilder<DoctorAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(DoctorAttachmentConfigurationConstants.TableName,
            DoctorAttachmentConfigurationConstants.SchemaName);

        // Configure composite primary key
        builder.HasKey(dsl => new { dsl.DoctorId, dsl.AttachmentId });

        // Configure relations
        builder.HasOne(da => da.Doctor)
            .WithMany(d => d.DoctorAttachments)
            .HasForeignKey(da => da.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(da => da.Attachment)
            .WithMany(d => d.DoctorAttachments)
            .HasForeignKey(a => a.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}