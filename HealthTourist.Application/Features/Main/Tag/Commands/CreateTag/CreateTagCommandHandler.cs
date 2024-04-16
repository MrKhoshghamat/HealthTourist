using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Commands.CreateTag;

public class CreateTagCommandHandler(ITagRepository tagRepository, IMapper mapper)
    : IRequestHandler<CreateTagCommand, int>
{
    public async Task<int> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        var tag = mapper.Map<Domain.Main.Tag>(request);
        await tagRepository.CreateAsync(tag);
        return tag.Id;
    }
}