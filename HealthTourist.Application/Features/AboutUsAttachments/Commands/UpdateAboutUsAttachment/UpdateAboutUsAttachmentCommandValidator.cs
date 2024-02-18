using FluentValidation;
using HealthTourist.Common.Constants.AboutUsAttachments;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.UpdateAboutUsAttachment;

public class UpdateAboutUsAttachmentCommandValidator : AbstractValidator<UpdateAboutUsAttachmentCommand>
{
    public UpdateAboutUsAttachmentCommandValidator()
    {
        RuleFor(x => x.AboutUsId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);

        RuleFor(x => x.AttachmentId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);
    }
}