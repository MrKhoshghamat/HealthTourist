using HealthTourist.Common.Constants.TeamMemberSocialMedias;
using HealthTourist.Common.Enumerations.AboutUs;
using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class TeamMemberSocialMediaConfiguration : IEntityTypeConfiguration<TeamMemberSocialMedia>
{
    public void Configure(EntityTypeBuilder<TeamMemberSocialMedia> builder)
    {
        builder.ToTable(TeamMemberSocialMediaConfigurationConstants.TableName,
            TeamMemberSocialMediaConfigurationConstants.SchemaName);
        
        builder.HasKey(tmsm => new { tmsm.TeamMemberId, tmsm.SocialMedia });

        builder.HasOne(tmsm => tmsm.TeamMember)
            .WithMany(tm => tm.TeamMemberSocialMedias)
            .HasForeignKey(tmsm => tmsm.TeamMemberId)
            .OnDelete(DeleteBehavior.Cascade);

        // Assume SocialMediaEnum is an enum type
        builder.Property(tmsm => tmsm.SocialMedia)
            .IsRequired()
            .HasConversion<int>();
    }
}