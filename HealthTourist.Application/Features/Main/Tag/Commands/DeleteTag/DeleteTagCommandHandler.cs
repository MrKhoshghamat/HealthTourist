using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.DeleteTag;

public class DeleteTagCommandHandler(ITagRepository tagRepository, IMapper mapper)
    : IRequestHandler<DeleteTagCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var tag = mapper.Map<Domain.Main.Tag>(request);
        await tagRepository.DeleteAsync(tag);
        return Unit.Value;
    }

    public async Task<Unit> Handle(DeleteTagByIdCommand request, CancellationToken cancellationToken)
    {
        await tagRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}