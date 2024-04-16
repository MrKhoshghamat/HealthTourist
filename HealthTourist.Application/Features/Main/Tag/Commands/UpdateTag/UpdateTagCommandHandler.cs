using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.UpdateTag;

public class UpdateTagCommandHandler(ITagRepository tagRepository, IMapper mapper)
    : IRequestHandler<UpdateTagCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var tag = mapper.Map<Domain.Main.Tag>(request);
        await tagRepository.UpdateAsync(tag);
        return Unit.Value;
    }
}