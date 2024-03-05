using AutoMapper;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Department;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Queries.GetPatientDetails;

public class GetPatientDetailsQueryHandler(
    IPatientRepository patientRepository,
    IMapper mapper,
    IAppLogger<GetPatientDetailsQueryHandler> logger)
    : IRequestHandler<GetPatientDetailsQuery, GetPatientDetailsDto>
{
    public async Task<GetPatientDetailsDto> Handle(GetPatientDetailsQuery request, CancellationToken cancellationToken)
    {
        // Fetch Required Data from Database
        var patient = await patientRepository.GetPatient(request.Id);

        // Check Fetched Record For Null
        if (patient == null) throw new NotFoundException(nameof(Patient), request);

        // Map Patients to Required Result
        var result = mapper.Map<GetPatientDetailsDto>(patient);
        
        // Logging
        logger.LogInformation(PatientLogConstants.GetPatientDetailsQueryLogMessage);

        // Return Result
        return result;
    }
}