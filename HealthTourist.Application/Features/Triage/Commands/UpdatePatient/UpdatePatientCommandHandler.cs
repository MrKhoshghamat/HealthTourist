using AutoMapper;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Department;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Commands.UpdatePatient;

public class UpdatePatientCommandHandler(IPatientRepository patientRepository, IMapper mapper) 
    : IRequestHandler<UpdatePatientCommand, Unit>
{
    public async Task<Unit> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new UpdatePatientCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(PatientExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map request to required data
        var patient = mapper.Map<Patient>(request);
        
        // Update
        await patientRepository.UpdateAsync(patient);

        // return result
        return Unit.Value;
    }
}