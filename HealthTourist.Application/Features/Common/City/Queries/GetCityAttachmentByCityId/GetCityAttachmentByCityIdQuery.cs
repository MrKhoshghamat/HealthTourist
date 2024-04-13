using MediatR;

namespace HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;

public record GetCityAttachmentByCityIdQuery(int CityId) : IRequest<GetCityAttachmentByCityIdDto>;
