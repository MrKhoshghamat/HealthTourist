using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Commands.DeletePatient;

public class DeletePatientCommandHandler (IPatientRepository patientRepository)
    : IRequestHandler<DeletePatientCommand, Unit>
{
    public async Task<Unit> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new DeletePatientCommandValidator(patientRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(PatientExceptionConstants.BadRequestExceptionMessage, validationResult);
        
        // Delete
        await patientRepository.DeleteAsync(request.Id);
        
        // Return result
        return Unit.Value;
    }
}