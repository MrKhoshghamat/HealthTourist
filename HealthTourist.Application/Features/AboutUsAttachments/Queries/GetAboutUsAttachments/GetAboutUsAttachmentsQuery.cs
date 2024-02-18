using MediatR;

namespace HealthTourist.Application.Features.AboutUsAttachments.Queries.GetAboutUsAttachments;

public record GetAboutUsAttachmentsQuery : IRequest<List<GetAboutUsAttachmentsDto>>;
