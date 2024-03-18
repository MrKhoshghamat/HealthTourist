using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.UpdateAboutUs;

public class UpdateAboutUsCommandHandler(IAboutUsRepository aboutUsRepository, IMapper mapper)
    : IRequestHandler<UpdateAboutUsCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(UpdateAboutUsCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new UpdateAboutUsCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map request to required data
        var aboutUs = mapper.Map<AboutUs>(request);
        
        // Update
        await aboutUsRepository.UpdateAsync(aboutUs);

        // return result
        return Unit.Value;
    }

    #endregion
}