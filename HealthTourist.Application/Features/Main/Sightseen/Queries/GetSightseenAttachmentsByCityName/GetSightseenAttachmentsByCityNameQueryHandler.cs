using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenAttachmentsByCityName;

public class GetSightseenAttachmentsByCityNameQueryHandler(
    ISightseenAttachmentRepository sightseenAttachmentRepository,
    IMapper mapper)
    : IRequestHandler<GetSightseenAttachmentsByCityNameQuery, List<GetSightseenAttachmentsByCityNameDto>>
{
    public async Task<List<GetSightseenAttachmentsByCityNameDto>> Handle(GetSightseenAttachmentsByCityNameQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var sightseenAttachments =
            await sightseenAttachmentRepository.GetAllAsync(sa => sa.Sightseen.City.Name == request.CityName);
        if (sightseenAttachments == null)
            throw new NotFoundException(nameof(List<SightseenAttachment>), request.CityName);

        var result = mapper.Map<List<GetSightseenAttachmentsByCityNameDto>>(sightseenAttachments);
        return result;
    }
}