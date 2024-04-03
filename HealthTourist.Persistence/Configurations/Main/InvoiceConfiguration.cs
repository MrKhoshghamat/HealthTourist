using HealthTourist.Common.Constants.Main.Invoice;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        // Configure table name and schema name
        builder.ToTable(InvoiceConfigurationConstants.TableName, InvoiceConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(i => i.Id);

        // Configure properties
        builder.Property(i => i.HealthId).IsRequired();
        builder.Property(i => i.TravelId).IsRequired();
        builder.Property(i => i.TotalPrice).IsRequired()
            .HasMaxLength(InvoiceConfigurationConstants.TotalPriceMaxLength);

        // Configure relationships
        builder.HasOne(i => i.Health)
            .WithMany(h => h.Invoices)
            .HasForeignKey(i => i.HealthId);

        builder.HasOne(i => i.Travel)
            .WithMany(t => t.Invoices)
            .HasForeignKey(i => i.TravelId);

        builder.HasMany(i => i.InvoiceCosts)
            .WithOne(ic => ic.Invoice)
            .HasForeignKey(ic => ic.InvoiceId);
    }
}