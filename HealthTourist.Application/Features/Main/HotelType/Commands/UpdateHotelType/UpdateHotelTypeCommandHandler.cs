using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.UpdateHotelType;

public class UpdateHotelTypeCommandHandler(IHotelTypeRepository hotelTypeRepository, IMapper mapper)
    : IRequestHandler<UpdateHotelTypeCommand, Unit>
{
    public async Task<Unit> Handle(UpdateHotelTypeCommand request, CancellationToken cancellationToken)
    {
        var hotelType = mapper.Map<Domain.Main.HotelType>(request);
        await hotelTypeRepository.UpdateAsync(hotelType);
        return Unit.Value;
    }
}