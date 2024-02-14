using HealthTourist.Application.Contracts.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;

public class DeleteAboutUsCommandHandler(IAboutUsRepository aboutUsRepository) 
    : IRequestHandler<DeleteAboutUsCommand, Unit>
{
    #region Handler

    public async Task<Unit> Handle(DeleteAboutUsCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        
        // Delete
        await aboutUsRepository.DeleteAsync(request.Id);
        
        // Return result
        return Unit.Value;
    }

    #endregion
}