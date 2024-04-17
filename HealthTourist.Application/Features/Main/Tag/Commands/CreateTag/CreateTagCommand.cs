using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.CreateTag;

public class CreateTagCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Title { get; set; }
}