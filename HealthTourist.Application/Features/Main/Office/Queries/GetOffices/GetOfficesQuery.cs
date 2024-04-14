using MediatR;

namespace HealthTourist.Application.Features.Main.Office.Queries.GetOffices;

public record GetOfficesQuery : IRequest<List<GetOfficesDto>>;
