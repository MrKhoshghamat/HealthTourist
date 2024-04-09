using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;

public record GetHotelAttachmentByHotelIdQuery(int HotelId) : IRequest<GetHotelAttachmentByHotelIdDto>;
