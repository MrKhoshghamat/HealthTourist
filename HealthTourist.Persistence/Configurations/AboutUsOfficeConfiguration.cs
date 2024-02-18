using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsOfficeConfiguration : IEntityTypeConfiguration<AboutUsOffice>
{
    public void Configure(EntityTypeBuilder<AboutUsOffice> builder)
    {
        builder.HasKey(aoo => new { aoo.AboutUsId, aoo.OfficeId });

        builder.HasOne(aoo => aoo.AboutUs)
            .WithMany()
            .HasForeignKey(aoo => aoo.AboutUsId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(aoo => aoo.Office)
            .WithMany()
            .HasForeignKey(aoo => aoo.OfficeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}