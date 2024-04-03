using MediatR;

namespace HealthTourist.Application.Features.Main.HotelRank.Queries.GetHotelRanks;

public record GetHotelRanksQuery : IRequest<List<GetHotelRanksDto>>;
