using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Commands.DeleteHotel;

public class DeleteHotelCommandHandler(IHotelRepository hotelRepository, IMapper mapper)
    : IRequestHandler<DeleteHotelCommand, Unit>
{
    public async Task<Unit> Handle(DeleteHotelCommand request, CancellationToken cancellationToken)
    {
        var hotel = mapper.Map<Domain.Main.Hotel>(request);
        await hotelRepository.DeleteAsync(hotel);
        return Unit.Value;
    }
    
    public async Task<Unit> Handle(DeleteHotelByIdCommand request, CancellationToken cancellationToken)
    {
        await hotelRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}