using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;

public class GetCityAttachmentByCityIdQueryHandler(ICityAttachmentRepository cityAttachmentRepository, IMapper mapper)
: IRequestHandler<GetCityAttachmentByCityIdQuery, GetCityAttachmentByCityIdDto>
{
    public async Task<GetCityAttachmentByCityIdDto> Handle(GetCityAttachmentByCityIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var cityAttachment = await cityAttachmentRepository.FindAsync(ca => ca.CityId == request.CityId);
        if (cityAttachment == null) throw new NotFoundException(nameof(CityAttachment), request.CityId);

        var result = mapper.Map<GetCityAttachmentByCityIdDto>(cityAttachment);
        return result;
    }
}