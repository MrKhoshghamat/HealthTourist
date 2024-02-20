using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Common;
using HealthTourist.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.DatabaseContexts;

public class HealthTouristDbContext : DbContext
{
    public HealthTouristDbContext(DbContextOptions<HealthTouristDbContext> options) : base(options)
    {
        
    }
    
    #region Dbsets

    public DbSet<AboutUs> AboutUsDbset { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<AboutUsAttachment> AboutUsAttachments { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<OfficeLocation> OfficeLocations { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<TeamMemberSocialMedia> TeamMemberSocialMedias { get; set; }
    public DbSet<TeamMemberState> TeamMemberStates { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonAttachment> PersonAttachments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<State> States { get; set; }

    #endregion

    #region Configurations

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

    #endregion
}