using MediatR;

namespace HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachmentDetails;

public record GetAttachmentDetailsQuery(Guid Id) : IRequest<GetAttachmentDetailsDto>;
