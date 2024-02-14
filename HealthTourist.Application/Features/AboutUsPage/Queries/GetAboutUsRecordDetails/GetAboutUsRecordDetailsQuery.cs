using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;

public record GetAboutUsRecordDetailsQuery(int Id) : IRequest<GetAboutUsRecordDetailsDto>;