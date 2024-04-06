using MediatR;

namespace HealthTourist.Application.Features.Main.Guest.Queries.GetGuestDetails;

public record GetGuestDetailsQuery(long Id) : IRequest<GetGuestDetailsDto>;
