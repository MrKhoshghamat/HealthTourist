using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRankDetails;

public record GetHotelRankDetailsQuery(int Id) : IRequest<GetHotelRankDetailsDto>;
