using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TeamMemberAttachmentConfiguration : IEntityTypeConfiguration<TeamMemberAttachment>
{
    public void Configure(EntityTypeBuilder<TeamMemberAttachment> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TeamMemberAttachmentConfigurationConstants.TableName,
            TeamMemberAttachmentConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(tma => new { tma.TeamMemberId, tma.AttachmentId });

        // Configure relations
        builder.HasOne(tma => tma.TeamMember)
            .WithMany(tm => tm.TeamMemberAttachments)
            .HasForeignKey(tma => tma.TeamMemberId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(tma => tma.Attachment)
            .WithMany(a => a.TeamMemberAttachments)
            .HasForeignKey(tma => tma.AttachmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}