using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Commands.CreateAboutUs;

public class CreateAboutUsCommand : IRequest<int>
{
    /// <summary>
    /// Title
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
}