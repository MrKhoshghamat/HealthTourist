using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelsByCityName;

public record GetHotelsByCityNameQuery(string CityName) : IRequest<List<GetHotelsByCityNameDto>>;
