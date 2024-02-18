using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;

public abstract class DeleteAboutUsCommand : IRequest<Unit>
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
}