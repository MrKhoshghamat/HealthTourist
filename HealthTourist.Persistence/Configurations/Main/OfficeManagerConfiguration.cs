using HealthTourist.Common.Constants.Main.OfficeManager;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class OfficeManagerConfiguration : IEntityTypeConfiguration<OfficeManager>
{
    public void Configure(EntityTypeBuilder<OfficeManager> builder)
    {
        // Configure table name and schema name
        builder.ToTable(OfficeManagerConfigurationConstants.TableName, OfficeManagerConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(om => om.Id);

        // Configure properties
        builder.Property(om => om.PersonId).IsRequired();
        builder.Property(om => om.OfficeId).IsRequired();

        // Configure relations
        builder.HasOne(om => om.Person)
            .WithOne(p => p.OfficeManager)
            .HasForeignKey<OfficeManager>(om => om.PersonId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(om => om.Office)
            .WithOne(o => o.OfficeManager)
            .HasForeignKey<OfficeManager>(om => om.OfficeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}