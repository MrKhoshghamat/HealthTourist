using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class HotelRankRepository(HealthTouristDbContext context, IAppLogger<HotelRank> logger)
    : Repository<HotelRank, int>(context, logger), IHotelRankRepository
{
}