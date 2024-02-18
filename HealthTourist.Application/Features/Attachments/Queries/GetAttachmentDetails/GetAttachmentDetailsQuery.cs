using MediatR;

namespace HealthTourist.Application.Features.Attachments.Queries.GetAttachmentDetails;

public abstract record GetAttachmentDetailsQuery(Guid Id) : IRequest<GetAttachmentDetailsDto>;