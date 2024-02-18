using FluentValidation;
using HealthTourist.Common.Constants.AboutUs;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.CreateAboutUs;

public class CreateAboutUsCommandValidator : AbstractValidator<CreateAboutUsCommand>
{
    public CreateAboutUsCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotNull().WithMessage(AboutUsValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsValidationConstants.NotEmptyMessage)
            .MaximumLength(AboutUsValidationConstants.TitleMaximumLength)
            .WithMessage(AboutUsValidationConstants.TitleMaximumLengthMessage);
        
        RuleFor(x=>x.Description)
            .NotNull().WithMessage(AboutUsValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsValidationConstants.NotEmptyMessage)
            .MaximumLength(AboutUsValidationConstants.DescriptionMaximumLength)
            .WithMessage(AboutUsValidationConstants.DescriptionMaximumLengthMessage);
    }
}