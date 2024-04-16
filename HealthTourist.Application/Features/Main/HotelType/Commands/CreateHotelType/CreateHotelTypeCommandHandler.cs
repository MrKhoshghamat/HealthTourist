using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Commands.CreateHotelType;

public class CreateHotelTypeCommandHandler(IHotelTypeRepository hotelTypeRepository, IMapper mapper)
    : IRequestHandler<CreateHotelTypeCommand, int>
{
    public async Task<int> Handle(CreateHotelTypeCommand request, CancellationToken cancellationToken)
    {
        var hotelType = mapper.Map<Domain.Main.HotelType>(request);
        await hotelTypeRepository.CreateAsync(hotelType);
        return hotelType.Id;
    }
}