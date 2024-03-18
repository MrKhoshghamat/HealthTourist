using HealthTourist.Common.Constants.TeamMemberStates;
using HealthTourist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class TeamMemberStateConfiguration : IEntityTypeConfiguration<TeamMemberState>
{
    public void Configure(EntityTypeBuilder<TeamMemberState> builder)
    {
        builder.ToTable(TeamMemberStateConfigurationConstants.TableName,
            TeamMemberStateConfigurationConstants.SchemaName);
        
        // Define composite primary key
        builder.HasKey(tms => new { tms.TeamMemberId, tms.StateId });

        // Define foreign key relationship with TeamMember
        builder.HasOne(tms => tms.TeamMember)
            .WithMany(tm => tm.TeamMemberStates)
            .HasForeignKey(tms => tms.TeamMemberId)
            .IsRequired();

        // Define foreign key relationship with State
        builder.HasOne(tms => tms.State)
            .WithMany(s=>s.TeamMemberStates)
            .HasForeignKey(tms => tms.StateId)
            .IsRequired();
    }
}