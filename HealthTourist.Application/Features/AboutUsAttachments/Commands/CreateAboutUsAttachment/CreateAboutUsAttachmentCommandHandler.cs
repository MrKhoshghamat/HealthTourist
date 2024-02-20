using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Common.Constants.AboutUsAttachments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Common;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.CreateAboutUsAttachment;

public class CreateAboutUsAttachmentCommandHandler(
    IAboutUsAttachmentRepository aboutUsAttachmentRepository,
    IAboutUsRepository aboutUsRepository,
    IAttachmentRepository attachmentRepository,
    IMapper mapper)
    : IRequestHandler<CreateAboutUsAttachmentCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(CreateAboutUsAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new CreateAboutUsAttachmentCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsAttachmentExceptionConstants.BadRequestExceptionMessage,
                validationResult);

        // Check the records exist
        var aboutUs = await aboutUsRepository.IsExistAsync(request.AboutUsId);
        if (!aboutUs) throw new NotFoundException(nameof(AboutUs), request.AboutUsId);
        var attachment = await attachmentRepository.IsExistAsync(request.AttachmentId);
        if (!attachment) throw new NotFoundException(nameof(Attachment), request.AttachmentId);

        // Map incoming request to domain model
        var aboutUsAttachment = mapper.Map<AboutUsAttachment>(request);

        // Insert record to database
        await aboutUsAttachmentRepository.CreateAsync(aboutUsAttachment);

        // Return Unit
        return Unit.Value;
    }

    #endregion
}