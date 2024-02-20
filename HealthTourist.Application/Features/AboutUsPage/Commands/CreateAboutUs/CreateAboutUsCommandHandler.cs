using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.CreateAboutUs;

public class CreateAboutUsCommandHandler(IAboutUsRepository aboutUsRepository, IMapper mapper)
    : IRequestHandler<CreateAboutUsCommand, int>
{
    #region Handler

    public async Task<int> Handle(CreateAboutUsCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new CreateAboutUsCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(AboutUsExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map incoming request to domain model
        var aboutUsRecord = mapper.Map<AboutUs>(request);

        // Insert record to database and return Id
        var result = await aboutUsRepository.CreateAboutUsAndGetIdAsync(aboutUsRecord);

        // Return result
        return result;
    }

    #endregion
}