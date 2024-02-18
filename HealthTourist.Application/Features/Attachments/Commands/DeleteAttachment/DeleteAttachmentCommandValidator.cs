using FluentValidation;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.Attachments;

namespace HealthTourist.Application.Features.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentCommandValidator : AbstractValidator<DeleteAttachmentCommand>
{
    private readonly IAttachmentRepository _attachmentRepository;
    public DeleteAttachmentCommandValidator(IAttachmentRepository attachmentRepository)
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage(AttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AttachmentValidationConstants.NotEmptyMessage);

        RuleFor(x => x)
            .MustAsync(AttachmentAlreadyDeleted)
            .WithMessage(AttachmentValidationConstants.AttachmentAlreadyIsDeletedMessage);
        
        _attachmentRepository = attachmentRepository;
    }

    private Task<bool> AttachmentAlreadyDeleted(DeleteAttachmentCommand command, CancellationToken cancellationToken)
    {
        return _attachmentRepository.IsDeletedAsync(command.Id);
    }
}