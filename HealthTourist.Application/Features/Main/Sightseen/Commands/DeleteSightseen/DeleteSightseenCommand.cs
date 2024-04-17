using HealthTourist.Domain.Common;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Sightseen.Commands.DeleteSightseen;

public class DeleteSightseenCommand : IRequest<Unit>
{
    public int CityId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public long Lat { get; set; }
    public long Long { get; set; }
}