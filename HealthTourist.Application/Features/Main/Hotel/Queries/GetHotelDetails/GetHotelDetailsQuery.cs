using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelDetails;

public record GetHotelDetailsQuery(int Id) : IRequest<GetHotelDetailsDto>;