using AutoMapper;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Department;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Queries.GetPatients;

public class GetPatientsQueryHandler(
    IPatientRepository patientRepository,
    IMapper mapper,
    IAppLogger<GetPatientsQueryHandler> logger)
    : IRequestHandler<GetPatientsQuery, List<GetPatientsDto>>
{
    #region Handler

    public async Task<List<GetPatientsDto>> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
    {
        // Fetch Required Data from Database
        var patients = await patientRepository.GetPatients();

        // Check Fetched Records For Null
        if (patients == null) throw new NotFoundException(nameof(List<Patient>), request);
        
        // Map Patients to Required Result
        var result = mapper.Map<List<GetPatientsDto>>(patients);
        
        // Logging
        logger.LogInformation(PatientLogConstants.GetPatientsQueryLogMessage);
        
        // Return Result
        return result;
    }

    #endregion
}