using HealthTourist.Application.Contracts.Persistence.Base;
using HealthTourist.Domain.AboutUsPage;

namespace HealthTourist.Application.Contracts.AboutUsAttachments;

public interface IAboutUsAttachmentRepository : IRepository<AboutUsAttachment>
{
    Task<bool> IsDeletedAsync(int aboutUsId, Guid attachmentId);
    Task<AboutUsAttachment> GetAboutUsAttachmentAsync(int aboutUsId, Guid attachmentId);
}