using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.Attachments;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentCommandHandler(IAttachmentRepository attachmentRepository) 
    : IRequestHandler<DeleteAttachmentCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new DeleteAttachmentCommandValidator(attachmentRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AttachmentExceptionConstants.BadRequestExceptionMessage, validationResult);
        
        // Delete
        await attachmentRepository.DeleteAsync(request.Id);
        
        // Return result
        return Unit.Value;
    }

    #endregion
}