using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Commands.UpdateHotel;

public class UpdateHotelCommandHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<UpdateHotelCommand, Unit>
{
    public async Task<Unit> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Domain.Main.Hotel>(request);
        await hotelRepository.UpdateAsync(hotel);
        return Unit.Value;
    }
}