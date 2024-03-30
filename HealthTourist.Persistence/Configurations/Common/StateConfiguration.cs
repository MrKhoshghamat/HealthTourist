using HealthTourist.Common.Constants.Common.State;
using HealthTourist.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthTourist.Persistence.Configurations.Common;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    [Obsolete("Obsolete")]
    public void Configure(EntityTypeBuilder<State> builder)
    {
        // Configure table name and schema name
        builder.ToTable(StateConfigurationConstants.TableName, StateConfigurationConstants.SchemaName);

        // Configure primary key
        builder.HasKey(s => s.Id);

        // Configure properties
        builder.Property(s => s.Name).IsRequired().HasMaxLength(StateConfigurationConstants.NameMaxLength)
            .HasColumnType(StateConfigurationConstants.VarcharColumnType);
        builder.Property(s => s.Title).IsRequired().HasMaxLength(StateConfigurationConstants.TitleMaxLength)
            .HasColumnType(StateConfigurationConstants.NVarcharColumnType);

        // Configure indexes
        builder.HasIndex(s => s.Name).IsClustered(false).IsUnique(false)
            .HasName(StateConfigurationConstants.NameIndex);
        builder.HasIndex(s => s.Title).IsClustered(false).IsUnique(false)
            .HasName(StateConfigurationConstants.TitleIndex);

        // Configure relations
        builder.HasOne(s => s.Country)
            .WithMany(c => c.States)
            .HasForeignKey(s => s.CountryId)
            .IsRequired();

        builder.HasMany(s => s.Cities)
            .WithOne(c => c.State)
            .HasForeignKey(c => c.StateId);
    }
}