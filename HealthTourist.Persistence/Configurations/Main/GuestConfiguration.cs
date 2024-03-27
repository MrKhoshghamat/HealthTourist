using HealthTourist.Common.Constants.Main.Guest;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        // Configure table name and schema name
        builder.ToTable(GuestConfigurationConstants.TableName, GuestConfigurationConstants.SchemaName);
        
        // Configure primary key
        builder.HasKey(g => g.Id);

        // Configure properties
        builder.Property(g => g.PersonId).IsRequired();

        // Configure relationships
        builder.HasOne(g => g.Person)
            .WithMany()
            .HasForeignKey(g => g.PersonId);

        builder.HasMany(g => g.TravelGuests)
            .WithOne(tg => tg.Guest)
            .HasForeignKey(tg => tg.GuestId);
    }
}