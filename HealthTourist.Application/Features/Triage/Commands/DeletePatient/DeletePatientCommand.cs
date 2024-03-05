using MediatR;

namespace HealthTourist.Application.Features.Triage.Commands.DeletePatient;

public class DeletePatientCommand : IRequest<Unit>
{
    /// <summary>
    /// Id
    /// </summary>
    public long Id { get; set; }
}