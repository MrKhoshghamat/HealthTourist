using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelTagsByHotelId;

public record GetHotelTagsByHotelIdQuery(int HotelId) : IRequest<GetHotelTagsByHotelIdDto>;
