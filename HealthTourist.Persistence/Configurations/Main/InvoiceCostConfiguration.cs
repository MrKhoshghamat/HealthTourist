using HealthTourist.Common.Constants.Main.InvoiceCost;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class InvoiceCostConfiguration : IEntityTypeConfiguration<InvoiceCost>
{
    public void Configure(EntityTypeBuilder<InvoiceCost> builder)
    {
        // Configure table name and schema name
        builder.ToTable(InvoiceCostConfigurationConstants.TableName, InvoiceCostConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(ic => ic.Id);

        // Configure properties
        builder.Property(ic => ic.InvoiceId).IsRequired();
        builder.Property(ic => ic.CostDetailsId).IsRequired();
        builder.Property(ic => ic.Cost).IsRequired().HasMaxLength(InvoiceCostConfigurationConstants.CostMaxLength)
            .HasColumnType(InvoiceCostConfigurationConstants.VarcharColumnType);

        // Configure relationships
        builder.HasOne(ic => ic.Invoice)
            .WithMany(i => i.InvoiceCosts)
            .HasForeignKey(ic => ic.InvoiceId);

        builder.HasOne(ic => ic.CostDetails)
            .WithMany()
            .HasForeignKey(ic => ic.CostDetailsId);
    }
}