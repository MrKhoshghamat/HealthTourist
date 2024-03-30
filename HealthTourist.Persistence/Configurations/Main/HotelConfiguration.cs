using HealthTourist.Common.Constants.Main.Hotel;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HotelConfigurationConstants.TableName, HotelConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(h => h.Id);

        // Configure properties
        builder.Property(h => h.HotelRankId).IsRequired();
        builder.Property(h => h.Name).IsRequired().HasMaxLength(HotelConfigurationConstants.NameMaxLength);
        builder.Property(h => h.Title).IsRequired().HasMaxLength(HotelConfigurationConstants.TitleMaxLength);
        builder.Property(h => h.CityId).IsRequired();
        builder.Property(h => h.Address).IsRequired().HasMaxLength(HotelConfigurationConstants.AddressMaxLength);
        builder.Property(h => h.Lat).IsRequired();
        builder.Property(h => h.Long).IsRequired();
        builder.Property(h => h.PostalCode).HasMaxLength(HotelConfigurationConstants.PostalCodeMaxLength);
        builder.Property(h => h.PhoneNumber1).HasMaxLength(HotelConfigurationConstants.PhoneNumber1MaxLength);
        builder.Property(h => h.PhoneNumber2).HasMaxLength(HotelConfigurationConstants.PhoneNumber2MaxLength);
        builder.Property(h => h.PhoneNumber3).HasMaxLength(HotelConfigurationConstants.PhoneNumber3MaxLength);
        builder.Property(h => h.Website).HasMaxLength(HotelConfigurationConstants.WebsiteMaxLength);
        builder.Property(h => h.Email).HasMaxLength(HotelConfigurationConstants.EmailMaxLength);
        builder.Property(h => h.NumberOfRooms).IsRequired();
        builder.Property(h => h.Description).HasMaxLength(HotelConfigurationConstants.DescriptionMaxLength);
        builder.Property(h => h.EstablishmentDate).IsRequired();

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false)
            .HasName(HotelConfigurationConstants.NameIndex);
        builder.HasIndex(a => a.Title).IsClustered(false)
            .HasName(HotelConfigurationConstants.TitleIndex);
        builder.HasIndex(a => a.Address).IsClustered(false)
            .HasName(HotelConfigurationConstants.AddressIndex);
        builder.HasIndex(a => a.PostalCode).IsClustered(false)
            .HasName(HotelConfigurationConstants.PostalCodeIndex);
        builder.HasIndex(a => a.PhoneNumber1).IsClustered(false)
            .HasName(HotelConfigurationConstants.PhoneNumber1Index);
        builder.HasIndex(a => a.PhoneNumber2).IsClustered(false)
            .HasName(HotelConfigurationConstants.PhoneNumber2Index);
        builder.HasIndex(a => a.PhoneNumber3).IsClustered(false)
            .HasName(HotelConfigurationConstants.PhoneNumber3Index);
        builder.HasIndex(a => a.Website).IsClustered(false)
            .HasName(HotelConfigurationConstants.WebsiteIndex);
        builder.HasIndex(a => a.Email).IsClustered(false)
            .HasName(HotelConfigurationConstants.EmailIndex);

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