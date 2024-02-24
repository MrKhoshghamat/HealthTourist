using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Attachments;
using HealthTourist.Application.Contracts.Offices;
using HealthTourist.Application.Contracts.TeamMembers;
using HealthTourist.Domain.AboutUsPage;
using HealthTourist.Domain.Common;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetCurrentAboutUs;

public class GetCurrentAboutUsQueryHandler(
    IAboutUsRepository aboutUsRepository,
    IAttachmentRepository attachmentRepository,
    ITeamMemberRepository teamMemberRepository,
    IOfficeRepository officeRepository)
    : IRequestHandler<GetCurrentAboutUsQuery, GetCurrentAboutUsDto>
{
    public async Task<GetCurrentAboutUsDto> Handle(GetCurrentAboutUsQuery request, CancellationToken cancellationToken)
    {
        // Fetch last About Us Record with every relations
        var currentAboutUs = await aboutUsRepository.GetCurrentAboutUs();

        // Initial new list of Attachment model
        var attachments = new List<Attachment>();

        // Initial new list of TeamMember model
        var teamMembers = new List<TeamMember>();

        // Initial new list of Office model
        var offices = new List<Office>();

        // Fill the attachment list with currentAboutUs attachment Ids
        foreach (var attachment in currentAboutUs.AboutUsAttachments)
        {
            attachments.Add(await attachmentRepository.FindAsync(attachment.AttachmentId));
        }

        // Fill the team member list with currentAboutUs team member Ids
        foreach (var teamMember in currentAboutUs.AboutUsTeamMembers)
        {
            teamMembers.Add(await teamMemberRepository.FindAsync(teamMember.TeamMemberId));
        }

        // Fill the office list with currentAboutUs office Ids
        foreach (var office in currentAboutUs.AboutUsOffices)
        {
            offices.Add(await officeRepository.FindAsync(office.OfficeId));
        }

        // Flat required result with datas
        var getCurrentAboutUsDto = new GetCurrentAboutUsDto()
        {
            Title = currentAboutUs.Title,
            Description = currentAboutUs.Description,
            Attachments = attachments,
            TeamMembers = teamMembers,
            Offices = offices
        };

        // Return Result
        return getCurrentAboutUsDto;
    }
}