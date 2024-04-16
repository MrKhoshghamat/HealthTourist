using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.DeleteHotelRank;

public class DeleteHotelRankCommandHandler(IHotelRankRepository hotelRankRepository, IMapper mapper)
    : IRequestHandler<DeleteHotelRankCommand, Unit>
{
    public async Task<Unit> Handle(DeleteHotelRankCommand request, CancellationToken cancellationToken)
    {
        var hotelRank = mapper.Map<Domain.Main.HotelRank>(request);
        await hotelRankRepository.DeleteAsync(hotelRank);
        return Unit.Value;
    }
}