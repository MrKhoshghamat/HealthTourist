using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;

public class DeleteAboutUsCommand : IRequest<Unit>
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
}