using System.Linq.Expressions;
using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Department;

namespace HealthTourist.Application.Contracts.Patients;

public interface IPatientRepository : IRepository<Patient, long>
{
    Task<IReadOnlyList<Patient>> GetPatients();
    Task<Patient?> GetPatient(long id);
    Task<long> CreatePatientAndGetId(Patient patient);
    Task<bool> IsDeletedAsync(long id);
}