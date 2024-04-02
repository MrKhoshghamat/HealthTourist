using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;

public class GetHotelsQueryHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<GetHotelsQuery, List<GetHotelsDto>>
{
    public async Task<List<GetHotelsDto>> Handle(GetHotelsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotels = await hotelRepository.GetAllAsync();
        if (hotels == null) throw new NotFoundException(nameof(List<Domain.Main.Hotel>), request);

        var result = mapper.Map<List<GetHotelsDto>>(hotels);
        return result;
    }
}