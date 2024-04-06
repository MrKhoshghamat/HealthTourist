using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using HealthTourist.Common.Exceptions;
using MediatR;

namespace HealthTourist.Application.Features.Main.Guest.Queries.GetGuestDetails;

public class GetGuestDetailsQueryHandler(IGuestRepository guestRepository, IMapper mapper)
    : IRequestHandler<GetGuestDetailsQuery, GetGuestDetailsDto>
{
    public async Task<GetGuestDetailsDto> Handle(GetGuestDetailsQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var guest = await guestRepository.FindAsync(request.Id);
        if (guest == null) throw new NotFoundException(nameof(Domain.Main.Guest), request.Id);

        var result = mapper.Map<GetGuestDetailsDto>(guest);
        return result;
    }
}