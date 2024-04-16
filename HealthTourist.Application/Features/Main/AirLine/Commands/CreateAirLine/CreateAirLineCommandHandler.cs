using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.CreateAirLine;

public class CreateAirLineCommandHandler(IAirLineRepository airLineRepository, IMapper mapper)
: IRequestHandler<CreateAirLineCommand, int>
{
    public async Task<int> Handle(CreateAirLineCommand request, CancellationToken cancellationToken)
    {
        var airLine = mapper.Map<Domain.Main.AirLine>(request);
        await airLineRepository.CreateAsync(airLine);
        return airLine.Id;
    }
}