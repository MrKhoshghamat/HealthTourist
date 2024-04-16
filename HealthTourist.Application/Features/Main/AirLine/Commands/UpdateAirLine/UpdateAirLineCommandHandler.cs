using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.UpdateAirLine;

public class UpdateAirLineCommandHandler(IAirLineRepository airLineRepository, IMapper mapper)
: IRequestHandler<UpdateAirLineCommand, Unit>
{
    public async Task<Unit> Handle(UpdateAirLineCommand request, CancellationToken cancellationToken)
    {
        var airLine = mapper.Map<Domain.Main.AirLine>(request);
        await airLineRepository.UpdateAsync(airLine);
        return Unit.Value;
    }
}