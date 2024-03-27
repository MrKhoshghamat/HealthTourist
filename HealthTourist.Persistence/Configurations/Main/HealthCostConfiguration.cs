using HealthTourist.Common.Constants.Main.HealthCost;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HealthCostConfiguration : IEntityTypeConfiguration<HealthCost>
{
    public void Configure(EntityTypeBuilder<HealthCost> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HealthCostConfigurationConstants.TableName, HealthCostConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(hc => hc.Id);

        // Configure properties
        builder.Property(hc => hc.HealthId).IsRequired();
        builder.Property(hc => hc.CostDetailsId).IsRequired();
        builder.Property(hc => hc.Cost).IsRequired()
            .HasMaxLength(HealthCostConfigurationConstants.CostMaxLength); // Adjust the length as per your needs

        // Configure relationships
        builder.HasOne(hc => hc.Health)
            .WithMany(h => h.HealthCosts)
            .HasForeignKey(hc => hc.HealthId);

        builder.HasOne(hc => hc.CostDetails)
            .WithMany()
            .HasForeignKey(hc => hc.CostDetailsId);
    }
}