using HealthTourist.Common.Constants.AboutUsOffices;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsOfficeConfiguration : IEntityTypeConfiguration<AboutUsOffice>
{
    public void Configure(EntityTypeBuilder<AboutUsOffice> builder)
    {
        builder.ToTable(AboutUsOfficeConfigurationConstants.TableName, 
            AboutUsOfficeConfigurationConstants.SchemaName);
        
        builder.HasKey(aoo => new { aoo.AboutUsId, aoo.OfficeId });

        builder.HasOne(aoo => aoo.AboutUs)
            .WithMany(ao=>ao.AboutUsOffices)
            .HasForeignKey(aoo => aoo.AboutUsId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(aoo => aoo.Office)
            .WithMany(ao=>ao.AboutUsOffices)
            .HasForeignKey(aoo => aoo.OfficeId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}