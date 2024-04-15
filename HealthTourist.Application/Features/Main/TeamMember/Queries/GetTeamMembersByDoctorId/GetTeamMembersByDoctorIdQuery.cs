using MediatR;

namespace HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembersByDoctorId;

public record GetTeamMembersByDoctorIdQuery(long DoctorId) : IRequest<List<GetTeamMembersByDoctorIdDto>>;
