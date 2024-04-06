using MediatR;

namespace HealthTourist.Application.Features.Main.Guest.Queries.GetGuests;

public record GetGuestsQuery : IRequest<List<GetGuestsDto>>;
