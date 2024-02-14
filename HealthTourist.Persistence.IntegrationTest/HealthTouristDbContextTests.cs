using HealthTourist.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.IntegrationTest;

public class HealthTouristDbContextTests
{
    private readonly HealthTouristDbContext _healthTouristDbContext;
    
    public HealthTouristDbContextTests()
    {
        var dbOptions = new DbContextOptionsBuilder<HealthTouristDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

        _healthTouristDbContext = new HealthTouristDbContext(dbOptions);
    }

    [Fact]
    public void Save_SetCreatedDateTimeValue()
    {
        
    }

    [Fact]
    public void Save_SetModificationDateTimeValue()
    {
        
    }

    [Fact]
    public void Save_SetDeletionDateTimeValue()
    {
        
    }
}