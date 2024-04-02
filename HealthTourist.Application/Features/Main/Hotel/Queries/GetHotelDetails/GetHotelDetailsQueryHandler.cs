using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelDetails;

public class GetHotelDetailsQueryHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<GetHotelDetailsQuery, GetHotelDetailsDto>
{
    public async Task<GetHotelDetailsDto> Handle(GetHotelDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotel = await hotelRepository.FindAsync(request.Id);
        if (hotel == null) throw new NotFoundException(nameof(Domain.Main.Hotel), request.Id);

        var result = mapper.Map<GetHotelDetailsDto>(hotel);
        return result;
    }
}