using FluentValidation;
using HealthTourist.Common.Constants.AboutUsAttachments;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.CreateAboutUsAttachment;

public class CreateAboutUsAttachmentCommandValidator : AbstractValidator<CreateAboutUsAttachmentCommand>
{
    public CreateAboutUsAttachmentCommandValidator()
    {
        RuleFor(x => x.AboutUsId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);
        
        RuleFor(x => x.AttachmentId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);
    }
}