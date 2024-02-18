using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Common;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.UpdateAboutUsAttachment;

public class UpdateAboutUsAttachmentCommandHandler(
    IAboutUsAttachmentRepository aboutUsAttachmentRepository,
    IAboutUsRepository aboutUsRepository,
    IAttachmentRepository attachmentRepository)
    : IRequestHandler<UpdateAboutUsAttachmentCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(UpdateAboutUsAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new UpdateAboutUsAttachmentCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Check the records exist
        var aboutUs = await aboutUsRepository.IsExistAsync(request.AboutUsId);
        if (!aboutUs) throw new NotFoundException(nameof(AboutUs), request.AboutUsId);
        var attachment = await attachmentRepository.IsExistAsync(request.AttachmentId);
        if (!attachment) throw new NotFoundException(nameof(Attachment), request.AttachmentId);

        // Fetch required data from database by Id
        var aboutUsAttachment = await aboutUsAttachmentRepository.GetAsync(request.AboutUsId, request.AttachmentId);

        // Update
        await aboutUsAttachmentRepository.UpdateAsync(aboutUsAttachment);

        // return result
        return Unit.Value;
    }

    #endregion
}