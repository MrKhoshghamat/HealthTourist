using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class HotelGalleryConfiguration : IEntityTypeConfiguration<HotelGallery>
{
    public void Configure(EntityTypeBuilder<HotelGallery> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelGalleryConfigurationConstants.TableName,
            HotelGalleryConfigurationConstants.SchemaName);

        // Configure composite primary key if needed
        builder.HasKey(hg => new { hg.HotelId, hg.AttachmentId });

        // Configure relations
        builder.HasOne(hg => hg.Hotel)
            .WithMany(h => h.HotelGalleries)
            .HasForeignKey(hg => hg.HotelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(hg => hg.Attachment)
            .WithMany(a => a.HotelGalleries)
            .HasForeignKey(hg => hg.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}