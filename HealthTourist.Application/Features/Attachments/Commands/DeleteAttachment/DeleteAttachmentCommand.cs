using MediatR;

namespace HealthTourist.Application.Features.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}