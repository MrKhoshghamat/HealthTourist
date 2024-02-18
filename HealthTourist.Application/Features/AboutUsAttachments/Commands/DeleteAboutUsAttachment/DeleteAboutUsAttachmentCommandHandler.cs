using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsAttachments;
using HealthTourist.Common.Constants.AboutUsAttachments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Commands.DeleteAboutUsAttachment;

public class DeleteAboutUsAttachmentCommandHandler(
    IAboutUsAttachmentRepository aboutUsAttachmentRepository,
    IMapperBase mapper) 
    : IRequestHandler<DeleteAboutUsAttachmentCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(DeleteAboutUsAttachmentCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new DeleteAboutUsAttachmentCommandValidator(aboutUsAttachmentRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsAttachmentExceptionConstants.BadRequestExceptionMessage,
                validationResult);

        // Map incoming request to domain model
        var aboutUsAttachment = mapper.Map<AboutUsAttachment>(request);

        // Insert record to database
        await aboutUsAttachmentRepository.DeleteAsync(aboutUsAttachment);

        // Return Unit
        return Unit.Value;
    }

    #endregion
}