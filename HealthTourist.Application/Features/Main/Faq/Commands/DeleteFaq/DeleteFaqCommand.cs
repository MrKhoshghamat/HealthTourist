using MediatR;

namespace HealthTourist.Application.Features.Main.Faq.Commands.DeleteFaq;

public class DeleteFaqCommand : IRequest<Unit>
{
    #region Properties

    public int FaqTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public bool IsFirstPage { get; set; }

    #endregion

    #region Relations

    public virtual Domain.Main.FaqType FaqType { get; set; }

    #endregion
}