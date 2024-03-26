using HealthTourist.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.DatabaseContexts;

public class HealthTouristDbContext : DbContext
{
    public HealthTouristDbContext(DbContextOptions<HealthTouristDbContext> options) : base(options)
    {
    }

    #region Dbsets

    #endregion

    #region Configurations

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HealthTouristDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default)
    {
        try
        {
            SetTimestamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void SetTimestamps()
    {
        foreach (var entry in ChangeTracker.Entries())
        {
            switch (entry.Entity)
            {
                case BaseEntity<int> intEntity:
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            intEntity.CreationDateTime = DateTime.UtcNow;
                            intEntity.CreatorId = "1";
                            break;
                        case EntityState.Modified:
                            intEntity.ModificationDateTime = DateTime.UtcNow;
                            intEntity.ModifierId = "1";
                            break;
                        case EntityState.Deleted:
                            intEntity.DeletionDateTime = DateTime.UtcNow;
                            intEntity.RemoverId = "1";
                            break;
                        case EntityState.Detached:
                            break;
                        case EntityState.Unchanged:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case BaseEntity<long> longEntity:
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            longEntity.CreationDateTime = DateTime.UtcNow;
                            longEntity.CreatorId = "1";
                            break;
                        case EntityState.Modified:
                            longEntity.ModificationDateTime = DateTime.UtcNow;
                            longEntity.ModifierId = "1";
                            break;
                        case EntityState.Deleted:
                            longEntity.DeletionDateTime = DateTime.UtcNow;
                            longEntity.RemoverId = "1";
                            break;
                        case EntityState.Detached:
                            break;
                        case EntityState.Unchanged:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case BaseEntity<Guid> guidEntity:
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            guidEntity.CreationDateTime = DateTime.UtcNow;
                            guidEntity.CreatorId = "1";
                            break;
                        case EntityState.Modified:
                            guidEntity.ModificationDateTime = DateTime.UtcNow;
                            guidEntity.ModifierId = "1";
                            break;
                        case EntityState.Deleted:
                            guidEntity.DeletionDateTime = DateTime.UtcNow;
                            guidEntity.RemoverId = "1";
                            break;
                        case EntityState.Detached:
                            break;
                        case EntityState.Unchanged:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
            }
        }
    }

    #endregion
}