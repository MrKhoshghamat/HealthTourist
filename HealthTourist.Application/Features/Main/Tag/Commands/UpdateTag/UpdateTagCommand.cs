using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.UpdateTag;

public class UpdateTagCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}