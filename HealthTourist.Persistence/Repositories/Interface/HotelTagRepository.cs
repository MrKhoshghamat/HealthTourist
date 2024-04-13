using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Domain.Interface;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Interface;

public class HotelTagRepository(HealthTouristDbContext context, IAppLogger<HotelTag> logger)
    : Repository<HotelTag>(context, logger), IHotelTagRepository
{
}