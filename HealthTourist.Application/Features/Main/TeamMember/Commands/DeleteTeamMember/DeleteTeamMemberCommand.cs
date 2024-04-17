using HealthTourist.Domain.Account;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Commands.DeleteTeamMember;

public class DeleteTeamMemberCommand : IRequest<Unit>
{
    public long PersonId { get; set; }
    public long DoctorId { get; set; }
    public int TreatmentId { get; set; }
}