using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HospitalGalleryConfiguration : IEntityTypeConfiguration<HospitalGallery>
{
    public void Configure(EntityTypeBuilder<HospitalGallery> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HospitalGalleryConfigurationConstants.TableName,
            HospitalGalleryConfigurationConstants.SchemaName);
        
        // Configure composite primary key
        builder.HasKey(hg => new { hg.HospitalId, hg.AttachmentId });

        // Configure relations
        builder.HasOne(hg => hg.Hospital)
            .WithMany(h => h.HospitalGalleries)
            .HasForeignKey(hg => hg.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(hg => hg.Attachment)
            .WithMany(a => a.HospitalGalleries)
            .HasForeignKey(hg => hg.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}