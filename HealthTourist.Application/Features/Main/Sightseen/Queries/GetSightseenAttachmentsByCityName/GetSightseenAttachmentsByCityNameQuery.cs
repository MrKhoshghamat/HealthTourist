using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenAttachmentsByCityName;

public record GetSightseenAttachmentsByCityNameQuery(string CityName)
    : IRequest<List<GetSightseenAttachmentsByCityNameDto>>;
