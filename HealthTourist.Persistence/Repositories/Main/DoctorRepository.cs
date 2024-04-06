using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Domain.Main;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;

namespace HealthTourist.Persistence.Repositories.Main;

public class DoctorRepository(HealthTouristDbContext context, IAppLogger<Doctor> logger)
    : Repository<Doctor, long>(context, logger), IDoctorRepository
{
}