using MediatR;

namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachments;

public abstract record GetAttachmentsQuery : IRequest<List<GetAttachmentsDto>>;
