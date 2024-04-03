using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypes;

public class GetHotelTypesQueryHandler(IHotelTypeRepository hotelTypeRepository, IMapper mapper)
    : IRequestHandler<GetHotelTypesQuery, List<GetHotelTypesDto>>
{
    public async Task<List<GetHotelTypesDto>> Handle(GetHotelTypesQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelTypes = await hotelTypeRepository.GetAllAsync();
        if (hotelTypes == null) throw new NotFoundException(nameof(List<Domain.Main.HotelType>), request);

        var result = mapper.Map<List<GetHotelTypesDto>>(hotelTypes);
        return result;
    }
}