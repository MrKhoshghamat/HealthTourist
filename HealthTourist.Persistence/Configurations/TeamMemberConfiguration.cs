using HealthTourist.Domain.AboutUsPage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations;

public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
{
    public void Configure(EntityTypeBuilder<TeamMember> builder)
    {
        builder.HasKey(tm => tm.Id);
        builder.Property(tm => tm.CareerPosition).IsRequired();
        builder.Property(tm => tm.Prefix).IsRequired();

        // Configure one-to-one relationship with Person
        builder.HasOne(tm => tm.Person)
            .WithOne(p => p.TeamMember)
            .HasForeignKey<TeamMember>(tm => tm.PersonId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}