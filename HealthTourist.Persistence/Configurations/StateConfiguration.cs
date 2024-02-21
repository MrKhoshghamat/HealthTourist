using HealthTourist.Common.Constants.States;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable(StateConfigurationConstants.TableName, StateConfigurationConstants.SchemaName);
        
        builder.Property(x => x.CreatorId).IsRequired(false);
        builder.Property(x => x.ModifierId).IsRequired(false);
        builder.Property(x => x.RemoverId).IsRequired(false);
        
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Title)
            .IsRequired()
            .HasMaxLength(StateConfigurationConstants.TitleMaxLength);
        
        builder.HasOne(s => s.Parent)
            .WithMany()
            .HasForeignKey(s => s.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.TeamMemberStates)
            .WithOne(tms => tms.State)
            .HasForeignKey(tms => tms.StateId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}