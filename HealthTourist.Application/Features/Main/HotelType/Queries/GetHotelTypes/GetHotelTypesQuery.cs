using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypes;

public record GetHotelTypesQuery : IRequest<List<GetHotelTypesDto>>;
