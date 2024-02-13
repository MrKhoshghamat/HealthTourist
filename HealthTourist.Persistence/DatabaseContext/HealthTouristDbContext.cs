using HealthTourist.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.DatabaseContext;

public class HealthTouristDbContext(DbContextOptions<HealthTouristDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HealthTouristDbContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity<int>>()
                     .Where(q => q.State is EntityState.Added or EntityState.Modified))
        {
            entry.Entity.ModificationDateTime = DateTime.Now;

            if (entry.State == EntityState.Added) entry.Entity.CreationDateTime = DateTime.Now;
        }
        
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity<long>>()
                     .Where(q => q.State is EntityState.Added or EntityState.Modified))
        {
            entry.Entity.ModificationDateTime = DateTime.Now;

            if (entry.State == EntityState.Added) entry.Entity.CreationDateTime = DateTime.Now;
        }
        
        foreach (var entry in base.ChangeTracker.Entries<BaseEntity<Guid>>()
                     .Where(q => q.State is EntityState.Added or EntityState.Modified))
        {
            entry.Entity.ModificationDateTime = DateTime.Now;

            if (entry.State == EntityState.Added) entry.Entity.CreationDateTime = DateTime.Now;
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}