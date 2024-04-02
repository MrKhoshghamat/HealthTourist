using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;

public record GetHotelsQuery : IRequest<List<GetHotelsDto>>;