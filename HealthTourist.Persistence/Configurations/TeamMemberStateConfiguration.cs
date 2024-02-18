using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class TeamMemberStateConfiguration : IEntityTypeConfiguration<TeamMemberState>
{
    public void Configure(EntityTypeBuilder<TeamMemberState> builder)
    {
        // Define composite primary key
        builder.HasKey(tms => new { tms.TeamMemberId, tms.StateId });

        // Define foreign key relationship with TeamMember
        builder.HasOne(tms => tms.TeamMember)
            .WithMany(tm => tm.TeamMemberStates)
            .HasForeignKey(tms => tms.TeamMemberId)
            .IsRequired();

        // Define foreign key relationship with State
        builder.HasOne(tms => tms.State)
            .WithMany()
            .HasForeignKey(tms => tms.StateId)
            .IsRequired();
    }
}