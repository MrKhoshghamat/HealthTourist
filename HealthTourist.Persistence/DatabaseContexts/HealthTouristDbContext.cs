using HealthTourist.Domain;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using HealthTourist.Domain.Main;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.DatabaseContexts;

public class HealthTouristDbContext : DbContext
{
    public HealthTouristDbContext(DbContextOptions<HealthTouristDbContext> options) : base(options)
    {
    }

    #region Dbsets

    #region Account

    public DbSet<Person> Persons { get; set; }

    #endregion

    #region Common

    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }

    #endregion

    #region Main

    public DbSet<AirLine> AirLines { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CostDetails> CostDetailsDbset { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Faq> Faqs { get; set; }
    public DbSet<FaqType> FaqTypes { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Health> Healths { get; set; }
    public DbSet<HealthCost> HealthCosts { get; set; }
    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<HospitalType> HospitalTypes { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelRank> HotelRanks { get; set; }
    public DbSet<HotelType> HotelTypes { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceCost> InvoiceCosts { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<OfficeManager> OfficeManagers { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Sightseen> Sightseens { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Travel> Travels { get; set; }
    public DbSet<TravelCost> TravelCosts { get; set; }
    public DbSet<Treatment> Treatments { get; set; }
    public DbSet<TreatmentType> TreatmentTypes { get; set; }
    public DbSet<Triage> Triages { get; set; }

    #endregion

    #region Interface

    public DbSet<HealthAttachment> HealthAttachments { get; set; }
    public DbSet<HospitalAttachment> HospitalAttachments { get; set; }
    public DbSet<HospitalGallery> HospitalGalleries { get; set; }
    public DbSet<HospitalTag> HospitalTags { get; set; }
    public DbSet<HotelAttachment> HotelAttachments { get; set; }
    public DbSet<HotelGallery> HotelGalleries { get; set; }
    public DbSet<HotelTag> HotelTags { get; set; }
    public DbSet<OfficeAttachment> OfficeAttachments { get; set; }
    public DbSet<SightseenAttachment> SightseenAttachments { get; set; }
    public DbSet<SightseenCategory> SightseenCategories { get; set; }
    public DbSet<TravelAttachment> TravelAttachments { get; set; }
    public DbSet<TravelGuest> TravelGuests { get; set; }
    public DbSet<TriageAttachment> TriageAttachments { get; set; }

    #endregion
    
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