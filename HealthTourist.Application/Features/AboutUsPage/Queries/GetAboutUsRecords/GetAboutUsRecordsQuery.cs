using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public abstract record GetAboutUsRecordsQuery : IRequest<List<GetAboutUsRecordsDto>>;
