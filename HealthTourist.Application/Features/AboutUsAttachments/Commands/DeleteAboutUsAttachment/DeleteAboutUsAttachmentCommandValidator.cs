using FluentValidation;
using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Common.Constants.AboutUsAttachments;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.DeleteAboutUsAttachment;

public class DeleteAboutUsAttachmentCommandValidator : AbstractValidator<DeleteAboutUsAttachmentCommand>
{
    private readonly IAboutUsAttachmentRepository _aboutUsAttachmentRepository;
    
    public DeleteAboutUsAttachmentCommandValidator(IAboutUsAttachmentRepository aboutUsAttachmentRepository)
    {
        RuleFor(x => x.AboutUsId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);
        
        RuleFor(x => x.AttachmentId)
            .NotNull().WithMessage(AboutUsAttachmentValidationConstants.NotNullMessage)
            .NotEmpty().WithMessage(AboutUsAttachmentValidationConstants.NotEmptyMessage);

        RuleFor(x => x)
            .MustAsync(AboutUsAttachmentAlreadyDeleted)
            .WithMessage(AboutUsAttachmentValidationConstants.AboutUsAttachmentAlreadyIsDeletedMessage);
        _aboutUsAttachmentRepository = aboutUsAttachmentRepository;
    }
    
    private async Task<bool> AboutUsAttachmentAlreadyDeleted(DeleteAboutUsAttachmentCommand command, CancellationToken cancellationToken)
    {
        return await _aboutUsAttachmentRepository.IsDeletedAsync(command.AboutUsId, command.AttachmentId);
    }
}