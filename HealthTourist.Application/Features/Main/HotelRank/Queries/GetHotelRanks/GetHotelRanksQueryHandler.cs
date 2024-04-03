using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRanks;

public class GetHotelRanksQueryHandler(IHotelRankRepository hotelRankRepository, IMapper mapper)
    : IRequestHandler<GetHotelRanksQuery, List<GetHotelRanksDto>>
{
    public async Task<List<GetHotelRanksDto>> Handle(GetHotelRanksQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelRanks = await hotelRankRepository.GetAllAsync();
        if (hotelRanks == null) throw new NotFoundException(nameof(List<Domain.Main.HotelRank>), request);

        var result = mapper.Map<List<GetHotelRanksDto>>(hotelRanks);
        return result;
    }
}