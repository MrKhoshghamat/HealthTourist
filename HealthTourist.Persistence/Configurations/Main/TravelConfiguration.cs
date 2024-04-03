using HealthTourist.Common.Constants.Main.Travel;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TravelConfiguration : IEntityTypeConfiguration<Travel>
{
    public void Configure(EntityTypeBuilder<Travel> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TravelConfigurationConstants.TableName, TravelConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(t => t.Id);

        // Configure properties
        builder.Property(t => t.TriageNo).IsRequired();
        builder.Property(t => t.PatientId).IsRequired();
        builder.Property(t => t.HotelId).IsRequired();
        builder.Property(t => t.AirLineId).IsRequired();
        builder.Property(t => t.Description).HasMaxLength(TravelConfigurationConstants.DescriptionMaxLength);
        builder.Property(t => t.Cost).HasMaxLength(TravelConfigurationConstants.CostMaxLength);

        // Configure relationships
        builder.HasOne(t => t.Patient)
            .WithMany(p => p.Travels)
            .HasForeignKey(t => t.PatientId);

        builder.HasOne(t => t.Hotel)
            .WithMany(h => h.Travels)
            .HasForeignKey(t => t.HotelId);

        builder.HasOne(t => t.AirLine)
            .WithMany(a => a.Travels)
            .HasForeignKey(t => t.AirLineId);

        builder.HasMany(t => t.Invoices)
            .WithOne(i => i.Travel)
            .HasForeignKey(i => i.TravelId);

        builder.HasMany(t => t.TravelCosts)
            .WithOne(tc => tc.Travel)
            .HasForeignKey(tc => tc.TravelId);

        builder.HasMany(t => t.TravelAttachments)
            .WithOne(ta => ta.Travel)
            .HasForeignKey(ta => ta.TravelId);

        builder.HasMany(t => t.TravelGuests)
            .WithOne(tg => tg.Travel)
            .HasForeignKey(tg => tg.TravelId);
    }
}