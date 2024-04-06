using MediatR;

namespace HealthTourist.Application.Features.Common.State.Queries.GetStates;

public record GetStatesQuery : IRequest<List<GetStatesDto>>;
