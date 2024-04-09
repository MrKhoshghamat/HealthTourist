using MediatR;

namespace HealthTourist.Application.Features.Main.Tag.Queries.GetTagDetails;

public record GetTagDetailsQuery(int Id) : IRequest<GetTagDetailsDto>;
