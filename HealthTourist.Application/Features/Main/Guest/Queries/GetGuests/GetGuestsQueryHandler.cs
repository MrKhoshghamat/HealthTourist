using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Guest.Queries.GetGuests;

public class GetGuestsQueryHandler(IGuestRepository guestRepository, IMapper mapper)
    : IRequestHandler<GetGuestsQuery, List<GetGuestsDto>>
{
    public async Task<List<GetGuestsDto>> Handle(GetGuestsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var guests = await guestRepository.GetAllAsync();
        if (guests == null) throw new NotFoundException(nameof(List<Domain.Main.Guest>), request);

        var result = mapper.Map<List<GetGuestsDto>>(guests);
        return result;
    }
}