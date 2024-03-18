using HealthTourist.Common.Constants.TeamMembers;
using HealthTourist.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
{
    public void Configure(EntityTypeBuilder<TeamMember> builder)
    {
        builder.ToTable(TeamMemberConfigurationConstants.TableName, TeamMemberConfigurationConstants.SchemaName);

        builder.HasKey(tm => tm.Id);
        builder.Property(tm => tm.CareerPosition).IsRequired();
        builder.Property(tm => tm.Prefix).IsRequired();

        // Configure one-to-one relationship with Person
        builder.HasOne(tm => tm.Person)
            .WithOne(p => p.TeamMember)
            .HasForeignKey<TeamMember>(tm => tm.PersonId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(tm => tm.CareerPosition)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(tm => tm.Prefix)
            .IsRequired()
            .HasConversion<int>();

        builder.HasMany(tm => tm.TeamMemberStates)
            .WithOne(tms => tms.TeamMember)
            .HasForeignKey(tms => tms.TeamMemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(tm => tm.TeamMemberSocialMedias)
            .WithOne(tmsm => tmsm.TeamMember)
            .HasForeignKey(tmsm => tmsm.TeamMemberId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(tm => tm.AboutUsTeamMembers)
            .WithOne(atm => atm.TeamMember)
            .HasForeignKey(atm => atm.TeamMemberId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}