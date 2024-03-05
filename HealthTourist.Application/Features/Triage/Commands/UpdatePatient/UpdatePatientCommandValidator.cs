using FluentValidation;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Constants.Persons;

namespace HealthTourist.Application.Features.Triage.Commands.UpdatePatient;

public class UpdatePatientCommandValidator : AbstractValidator<UpdatePatientCommand>
{
    public UpdatePatientCommandValidator()
    {
        RuleFor(x => x.FirstName)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage)
            .MaximumLength(PersonValidationConstants.FirstNameMaxLength)
            .WithMessage(PersonValidationConstants.FirstNameMaxLengthMessage);
        
        RuleFor(x => x.LastName)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage)
            .MaximumLength(PersonValidationConstants.LastNameMaxLength)
            .WithMessage(PersonValidationConstants.LastNameMaxLengthMessage);
        
        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage)
            .MaximumLength(PersonValidationConstants.PhoneNumberMaxLength)
            .WithMessage(PersonValidationConstants.PhoneNumberMaxLengthMessage);
        
        RuleFor(x => x.Email)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage)
            .MaximumLength(PersonValidationConstants.EmailMaxLength)
            .WithMessage(PersonValidationConstants.EmailMaxLengthMessage);

        RuleFor(x => x.Gender)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage);
        
        RuleFor(x => x.BirthDate)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage);

        RuleFor(x => x.Address)
            .NotNull().WithMessage(PersonValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PersonValidationConstants.NotEmptyMessage);

        RuleFor(x => x.Height)
            .NotNull().WithMessage(PatientValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PatientValidationConstants.NotEmptyMessage)
            .MaximumLength(PatientValidationConstants.HeightMaximumLength)
            .WithMessage(PatientValidationConstants.HeightMaximumLengthMessage);
        
        RuleFor(x => x.Weight)
            .NotNull().WithMessage(PatientValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(PatientValidationConstants.NotEmptyMessage)
            .MaximumLength(PatientValidationConstants.HeightMaximumLength)
            .WithMessage(PatientValidationConstants.HeightMaximumLengthMessage);
    }
}