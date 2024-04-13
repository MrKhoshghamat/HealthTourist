using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelTagsByHotelId;

public class GetHotelTagsByHotelIdQueryHandler(IHotelTagRepository hotelTagRepository, IMapper mapper)
: IRequestHandler<GetHotelTagsByHotelIdQuery, GetHotelTagsByHotelIdDto>
{
    public async Task<GetHotelTagsByHotelIdDto> Handle(GetHotelTagsByHotelIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelTags = await hotelTagRepository.GetAllAsync(ht => ht.HotelId == request.HotelId);
        if (hotelTags == null) throw new NotFoundException(nameof(HotelTag), request.HotelId);

        var result = mapper.Map<GetHotelTagsByHotelIdDto>(hotelTags);
        return result;
    }
}