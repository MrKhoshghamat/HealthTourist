using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Commands.CreateHotelRank;

public class CreateHotelRankCommandHandler(IHotelRankRepository hotelRankRepository, IMapper mapper)
    : IRequestHandler<CreateHotelRankCommand, int>
{
    public async Task<int> Handle(CreateHotelRankCommand request, CancellationToken cancellationToken)
    {
        var hotelRank = mapper.Map<Domain.Main.HotelRank>(request);
        await hotelRankRepository.CreateAsync(hotelRank);
        return hotelRank.Id;
    }
}