using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.UpdateHotelRank;

public class UpdateHotelRankCommandHandler(IHotelRankRepository hotelRankRepository, IMapper mapper)
    : IRequestHandler<UpdateHotelRankCommand, Unit>
{
    public async Task<Unit> Handle(UpdateHotelRankCommand request, CancellationToken cancellationToken)
    {
        var hotelRank = mapper.Map<Domain.Main.HotelRank>(request);
        await hotelRankRepository.UpdateAsync(hotelRank);
        return Unit.Value;
    }
}