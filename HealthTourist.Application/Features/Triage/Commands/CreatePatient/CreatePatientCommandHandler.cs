using AutoMapper;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Department;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Commands.CreatePatient;

public class CreatePatientCommandHandler(IPatientRepository patientRepository, IMapper mapper) 
    : IRequestHandler<CreatePatientCommand, long>
{
    public async Task<long> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new CreatePatientCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(PatientExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map incoming request to domain model
        var patient = mapper.Map<Patient>(request);

        // Insert record to database and return Id
        var result = await patientRepository.CreatePatientAndGetId(patient);

        // Return result
        return result;  
    }
}