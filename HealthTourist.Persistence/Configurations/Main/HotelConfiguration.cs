using HealthTourist.Common.Constants.Main.Hotel;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelConfigurationConstants.TableName, HotelConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(h => h.Id);

        // Configure properties
        builder.Property(h => h.HotelRankId).IsRequired();
        builder.Property(h => h.Name).IsRequired().HasMaxLength(100);
        builder.Property(h => h.Title).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
        builder.Property(h => h.CityId).IsRequired();
        builder.Property(h => h.Address).IsRequired().HasMaxLength(200);
        builder.Property(h => h.Lat).IsRequired();
        builder.Property(h => h.Long).IsRequired();
        builder.Property(h => h.PostalCode).HasMaxLength(20);
        builder.Property(h => h.PhoneNumber1).HasMaxLength(20);
        builder.Property(h => h.PhoneNumber2).HasMaxLength(20);
        builder.Property(h => h.PhoneNumber3).HasMaxLength(20);
        builder.Property(h => h.Website).HasMaxLength(100);
        builder.Property(h => h.Email).HasMaxLength(100);
        builder.Property(h => h.CheckInTime).HasMaxLength(20);
        builder.Property(h => h.CheckOutTime).HasMaxLength(20);
        builder.Property(h => h.NumberOfRooms).IsRequired();
        builder.Property(h => h.Description).HasMaxLength(500);
        builder.Property(h => h.EstablishmentDate).IsRequired();

        // Configure relationships
        builder.HasOne(h => h.HotelRank)
            .WithMany()
            .HasForeignKey(h => h.HotelRankId);

        builder.HasOne(h => h.City)
            .WithMany()
            .HasForeignKey(h => h.CityId);

        builder.HasMany(h => h.Travels)
            .WithOne(t => t.Hotel)
            .HasForeignKey(t => t.HotelId);

        builder.HasMany(h => h.HotelAttachments)
            .WithOne(ha => ha.Hotel)
            .HasForeignKey(ha => ha.HotelId);

        builder.HasMany(h => h.HotelGalleries)
            .WithOne(hg => hg.Hotel)
            .HasForeignKey(hg => hg.HotelId);

        builder.HasMany(h => h.HotelTags)
            .WithOne(ht => ht.Hotel)
            .HasForeignKey(ht => ht.HotelId);
    }
}