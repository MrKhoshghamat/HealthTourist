using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.UpdateAboutUs;

public class UpdateAboutUsCommandHandler(IAboutUsRepository aboutUsRepository)
    : IRequestHandler<UpdateAboutUsCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(UpdateAboutUsCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        
        // Fetch required data from database by Id
        var aboutUs = await aboutUsRepository.FindAsync(request.Id);

        // Update
        await aboutUsRepository.UpdateAsync(aboutUs);
        
        // return result
        return Unit.Value;
    }

    #endregion
}