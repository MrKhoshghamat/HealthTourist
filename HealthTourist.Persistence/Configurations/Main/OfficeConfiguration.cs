using HealthTourist.Common.Constants.Main.Office;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        // Configure table name and schema name
        builder.ToTable(OfficeConfigurationConstants.TableName, OfficeConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(o => o.Id);

        // Configure properties
        builder.Property(o => o.Name).IsRequired().HasMaxLength(OfficeConfigurationConstants.NameMaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.Title).IsRequired().HasMaxLength(OfficeConfigurationConstants.TitleMaxLength)
            .HasColumnType(OfficeConfigurationConstants.NVarcharColumnType);
        builder.Property(o => o.Address).IsRequired().HasMaxLength(OfficeConfigurationConstants.AddressMaxLength)
            .HasColumnType(OfficeConfigurationConstants.NVarcharColumnType);
        builder.Property(o => o.Lat).IsRequired();
        builder.Property(o => o.Long).IsRequired();
        builder.Property(o => o.CountryId).IsRequired();
        builder.Property(o => o.CityId).IsRequired();
        builder.Property(o => o.PostalCode).HasMaxLength(OfficeConfigurationConstants.PostalCodeMaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.PhoneNumber1).HasMaxLength(OfficeConfigurationConstants.PhoneNumber1MaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.PhoneNumber2).HasMaxLength(OfficeConfigurationConstants.PhoneNumber2MaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.PhoneNumber3).HasMaxLength(OfficeConfigurationConstants.PhoneNumber3MaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.Email).HasMaxLength(OfficeConfigurationConstants.EmailMaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.OwnerCommission).HasMaxLength(OfficeConfigurationConstants.OwnerCommissionMaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);
        builder.Property(o => o.PresentedCommission)
            .HasMaxLength(OfficeConfigurationConstants.PresentedCommissionMaxLength)
            .HasColumnType(OfficeConfigurationConstants.VarcharColumnType);

        // Configure indexes
        builder.HasIndex(o => o.Name).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.NameIndex);
        builder.HasIndex(o => o.Name).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.TitleIndex);
        builder.HasIndex(o => o.PhoneNumber1).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.PhoneNumber1Index);
        builder.HasIndex(o => o.PhoneNumber2).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.PhoneNumber2Index);
        builder.HasIndex(o => o.PhoneNumber3).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.PhoneNumber3Index);
        builder.HasIndex(o => o.Address).IsClustered(false).IsUnique(false)
            .HasName(OfficeConfigurationConstants.AddressIndex);

        // Configure relationships
        builder.HasOne(o => o.Country)
            .WithMany()
            .HasForeignKey(o => o.CountryId);

        builder.HasOne(o => o.City)
            .WithMany()
            .HasForeignKey(o => o.CityId);

        builder.HasMany(o => o.OfficeAttachments)
            .WithOne(oa => oa.Office)
            .HasForeignKey(oa => oa.OfficeId);
    }
}