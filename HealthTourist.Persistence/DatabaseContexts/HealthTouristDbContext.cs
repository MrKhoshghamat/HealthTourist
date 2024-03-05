using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Common;
using HealthTourist.Domain.Department;
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
    public DbSet<Patient?> Patients { get; set; }
    public DbSet<PatientAttachment> PatientAttachments { get; set; }

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