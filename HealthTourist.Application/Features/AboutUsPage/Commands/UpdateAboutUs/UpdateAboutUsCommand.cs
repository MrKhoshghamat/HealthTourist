using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.UpdateAboutUs;

public class UpdateAboutUsCommand : IRequest<Unit>
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
}