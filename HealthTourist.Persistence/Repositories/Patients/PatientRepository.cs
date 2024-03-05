using System.Data;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Domain.Department;
using HealthTourist.Persistence.DatabaseContexts;
using HealthTourist.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HealthTourist.Persistence.Repositories.Patients;

public class PatientRepository(HealthTouristDbContext context, IAppLogger<Patient> logger)
    : Repository<Patient, long>(context, logger), IPatientRepository
{
    public async Task<IReadOnlyList<Patient>> GetPatients()
    {
        try
        {
            return await context.Patients
                .Include(p => p.Person)
                .Where(p => !p.IsDeleted && !p.IsDisabled)
                .ToListAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<Patient?> GetPatient(long id)
    {
        try
        {
            return await context.Patients
                .Where(p => p.Id == id && !p.IsDeleted && !p.IsDisabled)
                .Include(p => p.Person)
                .FirstOrDefaultAsync();
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<long> CreatePatientAndGetId(Patient patient)
    {
        try
        {
            await context.Patients.AddAsync(patient);
            return patient.Id;
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }

    public async Task<bool> IsDeletedAsync(long id)
    {
        try
        {
            return await IsExistAsync(x => x.Id == id && !x.IsDeleted);
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            throw new DataException(e.Message);
        }
    }
}