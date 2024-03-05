using HealthTourist.Common.Constants.Departments;
using HealthTourist.Domain.Department;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class PatientAttachmentConfiguration : IEntityTypeConfiguration<PatientAttachment>
{
    public void Configure(EntityTypeBuilder<PatientAttachment> builder)
    {
        builder.ToTable(PatientAttachmentConfigurationConstants.TableName,
            PatientAttachmentConfigurationConstants.SchemaName);

        builder.HasKey(paa => new { paa.PatientId, paa.AttachmentId });

        builder.HasOne(paa => paa.Patient)
            .WithMany(pa => pa.PatientAttachments)
            .HasForeignKey(paa => paa.PatientId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(paa => paa.Attachment)
            .WithMany(a => a.PatientAttachments)
            .HasForeignKey(paa => paa.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}