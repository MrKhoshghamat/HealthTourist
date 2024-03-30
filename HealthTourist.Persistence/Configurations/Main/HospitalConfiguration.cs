using HealthTourist.Common.Constants.Main.Hospital;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        // Configure table name and schema name
        builder.ToTable(HospitalConfigurationConstants.TableName, HospitalConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(h => h.Id);

        // Configure properties
        builder.Property(h => h.HospitalTypeId).IsRequired();
        builder.Property(h => h.Name).IsRequired().HasMaxLength(HospitalConfigurationConstants.NameMaxLength);
        builder.Property(h => h.Title).IsRequired().HasMaxLength(HospitalConfigurationConstants.TitleMaxLength);
        builder.Property(h => h.CityId).IsRequired();
        builder.Property(h => h.Address).IsRequired().HasMaxLength(HospitalConfigurationConstants.AddressMaxLength);
        builder.Property(h => h.Lat).IsRequired();
        builder.Property(h => h.Long).IsRequired();
        builder.Property(h => h.PostalCode).HasMaxLength(HospitalConfigurationConstants.PostalCodeMaxLength);
        builder.Property(h => h.PhoneNumber1).HasMaxLength(HospitalConfigurationConstants.PhoneNumber1MaxLength);
        builder.Property(h => h.PhoneNumber2).HasMaxLength(HospitalConfigurationConstants.PhoneNumber2MaxLength);
        builder.Property(h => h.PhoneNumber3).HasMaxLength(HospitalConfigurationConstants.PhoneNumber3MaxLength);
        builder.Property(h => h.Email).HasMaxLength(HospitalConfigurationConstants.EmailMaxLength);
        builder.Property(h => h.NumberOfBeds).IsRequired();
        builder.Property(h => h.Description).HasMaxLength(HospitalConfigurationConstants.DescriptionMaxLength);
        builder.Property(h => h.EstablishmentDate).IsRequired();

        // Configure indexes
        builder.HasIndex(a => a.Name).IsClustered(false)
            .HasName(HospitalConfigurationConstants.NameIndex);
        builder.HasIndex(a => a.Name).IsClustered(false)
            .HasName(HospitalConfigurationConstants.TitleIndex);
        builder.HasIndex(a => a.PhoneNumber1).IsClustered(false)
            .HasName(HospitalConfigurationConstants.PhoneNumber1Index);
        builder.HasIndex(a => a.PhoneNumber2).IsClustered(false)
            .HasName(HospitalConfigurationConstants.PhoneNumber2Index);
        builder.HasIndex(a => a.PhoneNumber3).IsClustered(false)
            .HasName(HospitalConfigurationConstants.PhoneNumber3Index);
        builder.HasIndex(a => a.Address).IsClustered(false)
            .HasName(HospitalConfigurationConstants.AddressIndex);

        // Configure relationships
        builder.HasOne(h => h.HospitalType)
            .WithMany()
            .HasForeignKey(h => h.HospitalTypeId);

        builder.HasOne(h => h.City)
            .WithMany()
            .HasForeignKey(h => h.CityId);

        builder.HasMany(h => h.Doctors)
            .WithOne(d => d.Hospital)
            .HasForeignKey(d => d.HospitalId);

        builder.HasMany(h => h.Healths)
            .WithOne(he => he.Hospital)
            .HasForeignKey(he => he.HospitalId);

        builder.HasMany(h => h.HospitalAttachments)
            .WithOne(ha => ha.Hospital)
            .HasForeignKey(ha => ha.HospitalId);

        builder.HasMany(h => h.HospitalGalleries)
            .WithOne(hg => hg.Hospital)
            .HasForeignKey(hg => hg.HospitalId);

        builder.HasMany(h => h.HospitalTags)
            .WithOne(ht => ht.Hospital)
            .HasForeignKey(ht => ht.HospitalId);
    }
}