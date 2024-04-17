using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.DeleteTag;

public class DeleteTagCommand : IRequest<Unit>
{
    public string Name { get; set; }
    public string Title { get; set; }
}

public record DeleteTagByIdCommand(int Id) : IRequest<Unit>;