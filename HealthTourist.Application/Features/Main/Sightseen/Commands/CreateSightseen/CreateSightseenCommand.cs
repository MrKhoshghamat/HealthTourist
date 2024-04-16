using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Commands.CreateSightseen;

public class CreateSightseenCommand : IRequest<int>
{
    #region Properties

    public int CityId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }

    #endregion

    #region Relations

    public virtual City City { get; set; }
    public virtual ICollection<SightseenAttachment> SightseenAttachments { get; set; }
    public virtual ICollection<SightseenCategory> SightseenCategories { get; set; }

    #endregion
}