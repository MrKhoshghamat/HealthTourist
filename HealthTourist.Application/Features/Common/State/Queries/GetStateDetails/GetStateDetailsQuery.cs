using MediatR;

namespace HealthTourist.Application.Features.Common.State.Queries.GetStateDetails;

public record GetStateDetailsQuery(int Id) : IRequest<GetStateDetailsDto>;