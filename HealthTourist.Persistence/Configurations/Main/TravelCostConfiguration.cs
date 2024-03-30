using HealthTourist.Common.Constants.Main.TravelCost;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TravelCostConfiguration : IEntityTypeConfiguration<TravelCost>
{
    public void Configure(EntityTypeBuilder<TravelCost> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TravelCostConfigurationConstants.TableName, TravelCostConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(tc => tc.Id);

        // Configure properties
        builder.Property(tc => tc.TravelId).IsRequired();
        builder.Property(tc => tc.CostDetailsId).IsRequired();
        builder.Property(tc => tc.Cost).IsRequired().HasMaxLength(TravelCostConfigurationConstants.CostMaxLength)
            .HasColumnType(TravelCostConfigurationConstants.VarcharColumnType); // Adjust the length as per your needs

        // Configure relationships
        builder.HasOne(tc => tc.Travel)
            .WithMany(t => t.TravelCosts)
            .HasForeignKey(tc => tc.TravelId);

        builder.HasOne(tc => tc.CostDetails)
            .WithMany()
            .HasForeignKey(tc => tc.CostDetailsId);
    }
}