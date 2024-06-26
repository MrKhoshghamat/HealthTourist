using HealthTourist.Common.Constants.Main.CostDetails;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class CostDetailsConfiguration : IEntityTypeConfiguration<CostDetails>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<CostDetails> builder)
    {
        // Configure table name and schema name
        builder.ToTable(CostDetailsConfigurationConstants.TableName, CostDetailsConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(cd => cd.Id);

        // Configure properties
        builder.Property(cd => cd.Name).IsRequired().HasMaxLength(CostDetailsConfigurationConstants.NameMaxLength);
        builder.Property(cd => cd.Title).IsRequired().HasMaxLength(CostDetailsConfigurationConstants.TitleMaxLength);

        // Configure indexes
        builder.HasIndex(cd => cd.Name).IsClustered(false)
            .HasName(CostDetailsConfigurationConstants.NameIndex);
        builder.HasIndex(cd => cd.Title).IsClustered(false)
            .HasName(CostDetailsConfigurationConstants.TitleIndex);

        // Configure relationships
        builder.HasMany(cd => cd.HealthCosts)
            .WithOne(hc => hc.CostDetails)
            .HasForeignKey(hc => hc.CostDetailsId);

        builder.HasMany(cd => cd.InvoiceCosts)
            .WithOne(ic => ic.CostDetails)
            .HasForeignKey(ic => ic.CostDetailsId);

        builder.HasMany(cd => cd.TravelCosts)
            .WithOne(tc => tc.CostDetails)
            .HasForeignKey(tc => tc.CostDetailsId);
    }
}