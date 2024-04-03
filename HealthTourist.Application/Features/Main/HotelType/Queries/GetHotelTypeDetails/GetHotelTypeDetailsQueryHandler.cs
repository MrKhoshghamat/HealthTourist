using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypeDetails;

public class GetHotelTypeDetailsQueryHandler(IHotelTypeRepository hotelTypeRepository, IMapper mapper)
    : IRequestHandler<GetHotelTypeDetailsQuery, GetHotelTypeDetailsDto>
{
    public async Task<GetHotelTypeDetailsDto> Handle(GetHotelTypeDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelType = await hotelTypeRepository.FindAsync(request.Id);
        if (hotelType == null) throw new NotFoundException(nameof(Domain.Main.HotelType), request.Id);

        var result = mapper.Map<GetHotelTypeDetailsDto>(hotelType);
        return result;
    }
}