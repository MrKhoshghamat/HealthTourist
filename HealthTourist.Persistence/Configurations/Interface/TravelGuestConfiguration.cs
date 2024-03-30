using HealthTourist.Common.Constants.Interface;
using HealthTourist.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Interface;

public class TravelGuestConfiguration : IEntityTypeConfiguration<TravelGuest> 
{
    public void Configure(EntityTypeBuilder<TravelGuest> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TravelGuestConfigurationConstants.TableName,
            TravelGuestConfigurationConstants.SchemaName);
        
        // Configure composite primary key if needed
        builder.HasKey(tg => new { tg.TravelId, tg.GuestId });

        // Configure relations
        builder.HasOne(tg => tg.Travel)
            .WithMany(t => t.TravelGuests)
            .HasForeignKey(tg => tg.TravelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(tg => tg.Guest)
            .WithMany(g => g.TravelGuests)
            .HasForeignKey(tg => tg.GuestId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}