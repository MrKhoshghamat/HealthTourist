using AutoMapper;
using HealthTourist.Application.Contracts.Main;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Commands.DeleteAirLine;

public class DeleteAirLineCommandHandler(IAirLineRepository airLineRepository, IMapper mapper)
: IRequestHandler<DeleteAirLineCommand, Unit>
{
    public async Task<Unit> Handle(DeleteAirLineCommand request, CancellationToken cancellationToken)
    {
        var airLine = mapper.Map<Domain.Main.AirLine>(request);
        await airLineRepository.DeleteAsync(airLine);
        return Unit.Value;
    }
}