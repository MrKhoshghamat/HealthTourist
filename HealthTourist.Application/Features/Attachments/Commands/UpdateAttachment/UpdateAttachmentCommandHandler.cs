using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.Attachments;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.UpdateAttachment;

public class UpdateAttachmentCommandHandler(IAttachmentRepository attachmentRepository) 
    : IRequestHandler<UpdateAttachmentCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(UpdateAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new UpdateAttachmentCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AttachmentExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Fetch required data from database by Id
        var aboutUs = await attachmentRepository.FindAsync(request.Id);

        // Update
        await attachmentRepository.UpdateAsync(aboutUs);

        // return result
        return Unit.Value;
    }

    #endregion
}