using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.DeleteHotelType;

public class DeleteHotelTypeCommandHandler(IHotelTypeRepository hotelTypeRepository, IMapper mapper)
    : IRequestHandler<DeleteHotelTypeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteHotelTypeCommand request, CancellationToken cancellationToken)
    {
        var hotelType = mapper.Map<Domain.Main.HotelType>(request);
        await hotelTypeRepository.DeleteAsync(hotelType);
        return Unit.Value;
    }
}