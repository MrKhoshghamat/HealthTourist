using HealthTourist.Common.Constants.Main.TeamMember;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
{
    public void Configure(EntityTypeBuilder<TeamMember> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TeamMemberConfigurationConstants.TableName, TeamMemberConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(tm => tm.Id);

        // Configure properties
        builder.Property(tm => tm.PersonId).IsRequired();
        builder.Property(tm => tm.DoctorId).IsRequired();
        builder.Property(tm => tm.TreatmentId).IsRequired();

        // Configure relationships
        builder.HasOne(tm => tm.Person)
            .WithOne(p=>p.TeamMember)
            .HasForeignKey<TeamMember>(tm => tm.PersonId);

        builder.HasOne(tm => tm.Doctor)
            .WithMany(d => d.TeamMembers)
            .HasForeignKey(tm => tm.DoctorId);

        builder.HasOne(tm => tm.Treatment)
            .WithMany()
            .HasForeignKey(tm => tm.TreatmentId);
        
        builder.HasMany(tm => tm.TeamMemberSocialMediae)
            .WithOne(tmsm => tmsm.TeamMember)
            .HasForeignKey(tmsm => tmsm.TeamMemberId);
        
        builder.HasMany(tm => tm.TeamMemberAttachments)
            .WithOne(tma => tma.TeamMember)
            .HasForeignKey(tma => tma.TeamMemberId);
    }
}