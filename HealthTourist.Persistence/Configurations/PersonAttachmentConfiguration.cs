using HealthTourist.Domain.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class PersonAttachmentConfiguration : IEntityTypeConfiguration<PersonAttachment>
{
    public void Configure(EntityTypeBuilder<PersonAttachment> builder)
    {
        builder.HasKey(pa => new { pa.PersonId, pa.AttachmentId });
        builder.Property(pa => pa.ExtensionType).IsRequired();

        builder.HasOne(pa => pa.Person)
            .WithMany(p => p.PersonAttachments)
            .HasForeignKey(pa => pa.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pa => pa.Attachment)
            .WithMany(a => a.PersonAttachments)
            .HasForeignKey(pa => pa.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Property(pa => pa.ExtensionType)
            .IsRequired()
            .HasConversion<int>();
    }
}