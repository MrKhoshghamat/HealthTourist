using HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLines;
using MediatR;

namespace HealthTourist.Application.Features.Main.AirLine.Queries.GetAirLineDetails;

public record GetAirLineDetailsQuery(int Id) : IRequest<GetAirLineDetailsDto>;