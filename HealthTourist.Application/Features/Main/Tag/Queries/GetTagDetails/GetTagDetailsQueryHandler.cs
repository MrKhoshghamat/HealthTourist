using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Queries.GetTagDetails;

public class GetTagDetailsQueryHandler(ITagRepository tagRepository, IMapper mapper)
    : IRequestHandler<GetTagDetailsQuery, GetTagDetailsDto>
{
    public async Task<GetTagDetailsDto> Handle(GetTagDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var tag = await tagRepository.FindAsync(request.Id);
        if (tag == null) throw new NotFoundException(nameof(Domain.Main.Tag), request.Id);

        var result = mapper.Map<GetTagDetailsDto>(tag);
        return result;
    }
}