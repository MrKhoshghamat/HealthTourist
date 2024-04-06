using MediatR;

namespace HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachments;

public record GetAttachmentsQuery : IRequest<List<GetAttachmentsDto>>;
