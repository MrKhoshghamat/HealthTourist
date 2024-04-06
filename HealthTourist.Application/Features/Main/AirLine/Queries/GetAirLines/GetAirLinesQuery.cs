using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLines;

public record GetAirLinesQuery : IRequest<List<GetAirLinesDto>>;