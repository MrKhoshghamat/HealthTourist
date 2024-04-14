using HealthTourist.Api.Models.AboutUs.Main;
using HealthTourist.Api.Models.AboutUs.Sub;
using HealthTourist.Application.Features.Main.Office.Queries.GetOffices;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembers;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberSocialMediasByTeamMemberId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class AboutUsController(IMediator mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetAboutUsDto> AboutUs()
        {
            var getAboutUsDto = new GetAboutUsDto();

            var teamMembers = await mediator.Send(new GetTeamMembersQuery());
            var offices = await mediator.Send(new GetOfficesQuery());

            foreach (var teamMember in teamMembers)
            {
                var teamMemberSocialMediae =
                    await mediator.Send(new GetTeamMemberSocialMediasByTeamMemberIdQuery(teamMember.Id));

                getAboutUsDto.TeamMembers =
                [
                    new AboutUsTeamMemberDto()
                    {
                        FirstName = teamMember.Person.FirstName,
                        LastName = teamMember.Person.LastName,
                        SocialMediae = teamMemberSocialMediae.SocialMediae
                    }
                ];
            }

            foreach (var office in offices)
            {
                getAboutUsDto.Offices =
                [
                    new AboutUsOfficeDto()
                    {
                        Name = office.Name,
                        Title = office.Title,
                        PhoneNumber = office.PhoneNumber1,
                        Email = office.Email,
                        Address = office.Address,
                        Lat = office.Lat,
                        Long = office.Long
                    }
                ];
            }

            return getAboutUsDto;
        }
    }
}