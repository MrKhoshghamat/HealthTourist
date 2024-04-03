using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRankDetails;

public class GetHotelRankDetailsQueryHandler(IHotelRankRepository hotelRankRepository, IMapper mapper)
    : IRequestHandler<GetHotelRankDetailsQuery, GetHotelRankDetailsDto>
{
    public async Task<GetHotelRankDetailsDto> Handle(GetHotelRankDetailsQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelRank = await hotelRankRepository.FindAsync(request.Id);
        if (hotelRank == null) throw new NotFoundException(nameof(Domain.Main.HotelRank), request.Id);

        var result = mapper.Map<GetHotelRankDetailsDto>(hotelRank);
        return result;
    }
}