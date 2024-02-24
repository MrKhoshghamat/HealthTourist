using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetCurrentAboutUs;

public record GetCurrentAboutUsQuery : IRequest<GetCurrentAboutUsDto>;
