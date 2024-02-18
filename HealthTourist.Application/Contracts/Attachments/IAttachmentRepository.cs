using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.Contracts.Attachments;

public interface IAttachmentRepository : IRepository<Attachment, Guid>
{
    Task<Guid> CreateAttachmentAndGetIdAsync(Attachment attachment);
    Task<bool> IsDeletedAsync(Guid id);
}