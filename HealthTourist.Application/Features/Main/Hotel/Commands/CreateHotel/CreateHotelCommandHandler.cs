using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Commands.CreateHotel;

public class CreateHotelCommandHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<CreateHotelCommand, int>
{
    public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Domain.Main.Hotel>(request);
        await hotelRepository.CreateAsync(hotel);
        return hotel.Id;
    }
}