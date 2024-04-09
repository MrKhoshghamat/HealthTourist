using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Queries.GetTags;

public class GetTagsQueryHandler(ITagRepository tagRepository, IMapper mapper)
    : IRequestHandler<GetTagsQuery, List<GetTagsDto>>
{
    public async Task<List<GetTagsDto>> Handle(GetTagsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var tags = await tagRepository.GetAllAsync();
        if (tags == null) throw new NotFoundException(nameof(List<Domain.Main.Tag>), request);

        var result = mapper.Map<List<GetTagsDto>>(tags);
        return result;
    }
}