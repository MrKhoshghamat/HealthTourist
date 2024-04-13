using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelsByCityName;

public class GetHotelsByCityNameQueryHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<GetHotelsByCityNameQuery, List<GetHotelsByCityNameDto>>
{
    public async Task<List<GetHotelsByCityNameDto>> Handle(GetHotelsByCityNameQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotels = await hotelRepository.GetAllAsync(h => h.City.Name == request.CityName);
        if (hotels == null) throw new NotFoundException(nameof(List<Domain.Main.Hotel>), request.CityName);

        var result = mapper.Map<List<GetHotelsByCityNameDto>>(hotels);
        return result;
    }
}