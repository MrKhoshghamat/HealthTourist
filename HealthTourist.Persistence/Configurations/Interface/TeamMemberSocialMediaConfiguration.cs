using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TeamMemberSocialMediaConfiguration : IEntityTypeConfiguration<TeamMemberSocialMedia>
{
    public void Configure(EntityTypeBuilder<TeamMemberSocialMedia> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TeamMemberSocialMediaConfigurationConstants.TableName,
            TeamMemberSocialMediaConfigurationConstants.SchemaName);

        // Configure composite primary key
        builder.HasKey(tmsm => new { tmsm.TeamMemberId });

        // Configure relations
        builder.HasOne(tmsm => tmsm.TeamMember)
            .WithMany(tm => tm.TeamMemberSocialMediae)
            .HasForeignKey(tmsm => tmsm.TeamMemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}