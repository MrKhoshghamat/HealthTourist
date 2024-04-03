using MediatR;

namespace HealthTourist.Application.Features.Main.HotelType.Queries.GetHotelTypeDetails;

public record GetHotelTypeDetailsQuery(int Id) : IRequest<GetHotelTypeDetailsDto>;
