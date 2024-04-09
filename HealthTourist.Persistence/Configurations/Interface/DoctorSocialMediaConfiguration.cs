using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class DoctorSocialMediaConfiguration : IEntityTypeConfiguration<DoctorSocialMedia>
{
    public void Configure(EntityTypeBuilder<DoctorSocialMedia> builder)
    {
        // Configure table name and schema name
        builder.ToTable(DoctorSocialMediaConfigurationConstants.TableName,
            DoctorSocialMediaConfigurationConstants.SchemaName);

        // Configure composite primary key
        builder.HasKey(dsl => new { dsl.DoctorId });

        // Configure relations
        builder.HasOne(dsl => dsl.Doctor)
            .WithMany(d => d.DoctorSocialMediae)
            .HasForeignKey(dsl => dsl.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}