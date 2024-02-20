using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public record GetAboutUsRecordsQuery : IRequest<List<GetAboutUsRecordsDto>>;
