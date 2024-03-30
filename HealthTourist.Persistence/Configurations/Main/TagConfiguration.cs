using HealthTourist.Common.Constants.Main.Tag;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Main;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        // Configure table name and schema name
        builder.ToTable(TagConfigurationConstants.TableName, TagConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(t => t.Id);

        // Configure properties
        builder.Property(t => t.Name).IsRequired().HasMaxLength(TagConfigurationConstants.NameMaxLength);
        builder.Property(t => t.Title).IsRequired().HasMaxLength(TagConfigurationConstants.TitleMaxLength);

        // Configure relationships
        builder.HasMany(t => t.HospitalTags)
            .WithOne(ht => ht.Tag)
            .HasForeignKey(ht => ht.TagId);

        builder.HasMany(t => t.HotelTags)
            .WithOne(ht => ht.Tag)
            .HasForeignKey(ht => ht.TagId);
    }
}