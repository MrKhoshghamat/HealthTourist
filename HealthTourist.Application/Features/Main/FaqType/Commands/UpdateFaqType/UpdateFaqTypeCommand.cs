using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.FaqType.Commands.UpdateFaqType;

public class UpdateFaqTypeCommand : IRequest<Unit>
{
    #region Properties

    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<Domain.Main.Faq> Faqs { get; set; }
    public virtual ICollection<FaqTypeAttachment> FaqTypeAttachments { get; set; }

    #endregion
}