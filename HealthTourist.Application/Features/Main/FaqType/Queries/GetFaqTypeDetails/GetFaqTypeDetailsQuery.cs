using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeDetails;

public record GetFaqTypeDetailsQuery(int Id) : IRequest<GetFaqTypeDetailsDto>;
