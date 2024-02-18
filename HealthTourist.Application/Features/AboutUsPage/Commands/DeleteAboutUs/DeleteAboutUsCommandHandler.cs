using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;

public class DeleteAboutUsCommandHandler(IAboutUsRepository aboutUsRepository) 
    : IRequestHandler<DeleteAboutUsCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(DeleteAboutUsCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new DeleteAboutUsCommandValidator(aboutUsRepository);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsExceptionConstants.BadRequestExceptionMessage, validationResult);
        
        // Delete
        await aboutUsRepository.DeleteAsync(request.Id);
        
        // Return result
        return Unit.Value;
    }

    #endregion
}