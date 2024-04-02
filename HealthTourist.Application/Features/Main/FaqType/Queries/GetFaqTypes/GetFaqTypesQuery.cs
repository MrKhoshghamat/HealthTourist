using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;

public record GetFaqTypesQuery : IRequest<List<GetFaqTypesDto>>;
