using FluentValidation;
using HealthTourist.Common.Constants.Attachments;
using HealthTourist.Common.Enumerations.Common;

namespace HealthTourist.Application.Features.Attachments.Commands.UpdateAttachment;

public class UpdateAttachmentCommandValidator : AbstractValidator<UpdateAttachmentCommand>
{
    public UpdateAttachmentCommandValidator()
    {
        RuleFor(x => x.Data)
            .NotNull().WithMessage(AttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AttachmentValidationConstants.NotEmptyMessage);

        RuleFor(x => x.FileExtension)
            .NotNull().WithMessage(AttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AttachmentValidationConstants.NotEmptyMessage)
            .MustAsync(BeValidFileExtension)
            .WithMessage(AttachmentValidationConstants.InvalidFileExtensionMessage);
    }
    
    private static async Task<bool> BeValidFileExtension(string fileExtension, CancellationToken cancellationToken)
    {
        var allowedFormats = Enum.GetNames(typeof(FileExtensionEnum));
        return await Task.FromResult(Array.Exists(allowedFormats,
            e => e.Equals(fileExtension, StringComparison.InvariantCultureIgnoreCase)));
    }
}