using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentsByHotelId;

public record GetHotelAttachmentsByHotelIdQuery(int HotelId) : IRequest<GetHotelAttachmentsByHotelIdDto>;
