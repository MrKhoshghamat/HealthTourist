using FluentValidation;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;

namespace HealthTourist.Application.Features.Triage.Commands.DeletePatient;

public class DeletePatientCommandValidator : AbstractValidator<DeletePatientCommand>
{
    private readonly IPatientRepository _patientRepository;
    
    public DeletePatientCommandValidator(IPatientRepository patientRepository)
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage(PatientValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PatientValidationConstants.NotEmptyMessage);

        RuleFor(x => x)
            .MustAsync(PatientAlreadyDeleted)
            .WithMessage(PatientValidationConstants.PatientAlreadyIsDeletedMessage);
        
        _patientRepository = patientRepository;
    }

    private async Task<bool> PatientAlreadyDeleted(DeletePatientCommand command, CancellationToken cancellationToken)
    {
        return await _patientRepository.IsDeletedAsync(command.Id);
    }
}