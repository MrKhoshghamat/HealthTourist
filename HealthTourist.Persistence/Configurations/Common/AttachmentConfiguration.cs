using HealthTourist.Common.Constants.Common.Attachment;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Common;

public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(AttachmentConfigurationConstants.TableName, AttachmentConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(a => a.Id);

        // Configure properties
        builder.Property(a => a.Content).IsRequired();
        builder.Property(a => a.Name).IsRequired().HasMaxLength(AttachmentConfigurationConstants.NameMaxlength)
            .HasColumnType(AttachmentConfigurationConstants.VarcharColumnType);
        builder.Property(a => a.Extension).IsRequired()
            .HasColumnType(AttachmentConfigurationConstants.VarcharColumnType);

        // Configure enums
        builder.Property(a => a.Extension)
            .IsRequired()
            .HasConversion<int>(); // Convert enum to int

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false).IsUnique(false)
            .HasName(AttachmentConfigurationConstants.NameIndex);

        // Configure relationships
        builder.HasMany(a => a.HealthAttachments)
            .WithOne(ha => ha.Attachment)
            .HasForeignKey(ha => ha.AttachmentId);

        builder.HasMany(a => a.HospitalAttachments)
            .WithOne(ha => ha.Attachment)
            .HasForeignKey(ha => ha.AttachmentId);

        builder.HasMany(a => a.HospitalGalleries)
            .WithOne(hg => hg.Attachment)
            .HasForeignKey(hg => hg.AttachmentId);

        builder.HasMany(a => a.HotelAttachments)
            .WithOne(ha => ha.Attachment)
            .HasForeignKey(ha => ha.AttachmentId);

        builder.HasMany(a => a.HotelGalleries)
            .WithOne(hg => hg.Attachment)
            .HasForeignKey(hg => hg.AttachmentId);

        builder.HasMany(a => a.OfficeAttachments)
            .WithOne(oa => oa.Attachment)
            .HasForeignKey(oa => oa.AttachmentId);

        builder.HasMany(a => a.SightseenAttachments)
            .WithOne(sa => sa.Attachment)
            .HasForeignKey(sa => sa.AttachmentId);

        builder.HasMany(a => a.TravelAttachments)
            .WithOne(ta => ta.Attachment)
            .HasForeignKey(ta => ta.AttachmentId);

        builder.HasMany(a => a.TriageAttachments)
            .WithOne(ta => ta.Attachment)
            .HasForeignKey(ta => ta.AttachmentId);
    }
}