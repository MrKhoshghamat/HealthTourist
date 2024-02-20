using AutoMapper;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.Attachments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Common;
using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.CreateAttachment;

public class CreateAttachmentCommandHandler(IAttachmentRepository attachmentRepository, IMapper mapper)
    : IRequestHandler<CreateAttachmentCommand, Guid>
{
    #region Handler

    public async Task<Guid> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new CreateAttachmentCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AttachmentExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map incoming request to domain model
        var attachment = mapper.Map<Attachment>(request);

        // Insert record to database and return Id
        var result = await attachmentRepository.CreateAttachmentAndGetIdAsync(attachment);

        // Return result
        return result;
    }

    #endregion
}