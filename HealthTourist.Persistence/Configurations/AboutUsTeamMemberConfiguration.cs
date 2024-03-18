using HealthTourist.Common.Constants.AboutUsTeamMembers;
using HealthTourist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class AboutUsTeamMemberConfiguration : IEntityTypeConfiguration<AboutUsTeamMember>
{
    public void Configure(EntityTypeBuilder<AboutUsTeamMember> builder)
    {
        builder.ToTable(AboutUsTeamMemberConfigurationConstants.TableName,
            AboutUsTeamMemberConfigurationConstants.SchemaName);

        builder.HasKey(atm => new { atm.AboutUsId, atm.TeamMemberId });

        builder.HasOne(atm => atm.AboutUs)
            .WithMany(a => a.AboutUsTeamMembers)
            .HasForeignKey(atm => atm.AboutUsId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(atm => atm.TeamMember)
            .WithMany(tm => tm.AboutUsTeamMembers)
            .HasForeignKey(atm => atm.TeamMemberId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}