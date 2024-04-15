using HealthTourist.Api.Models.Department.Main;
using HealthTourist.Api.Models.Department.Sub;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountryCodes;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMemberAttachmentByTeamMemberId;
using HealthTourist.Application.Features.Main.TeamMember.Queries.GetTeamMembersByDoctorId;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class DepartmentController(IMediator mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetDepartmentDto> GetDepartment()
        {
            var getDepartmentDto = new GetDepartmentDto();

            var treatmentTypes = await mediator.Send(new GetTreatmentTypesQuery());
            var doctors = await mediator.Send(new GetDoctorsQuery());

            foreach (var treatmentType in treatmentTypes)
            {
                var treatmentTypeIcon =
                    await mediator.Send(new GetTreatmentTypeIconByTreatmentTypeIdQuery(treatmentType.Id));

                getDepartmentDto.TreatmentTypes =
                [
                    new DepartmentTreatmentTypeDto()
                    {
                        Name = treatmentType.Name,
                        Title = treatmentType.Title,
                        Icon = treatmentTypeIcon.Content
                    }
                ];
            }

            foreach (var doctor in doctors)
            {
                var doctorSocialMedia = await mediator.Send(new GetDoctorSocialMediasByDoctorIdQuery(doctor.Id));
                var doctorAttachment = await mediator.Send(new GetDoctorAttachmentByDoctorIdQuery(doctor.Id));

                getDepartmentDto.HealthDepartmentManagers.Doctors =
                [
                    new DepartmentDoctorDto()
                    {
                        FirstName = doctor.Person.FirstName,
                        LastName = doctor.Person.LastName,
                        Treatment = doctor.Treatment.Title,
                        Picture = doctorAttachment.Content,
                        SocialMediae = doctorSocialMedia.SocialMediae,
                        SocialMediaLinks = doctorSocialMedia.Links
                    }
                ];

                var teamMembers = await mediator.Send(new GetTeamMembersByDoctorIdQuery(doctor.Id));

                foreach (var teamMember in teamMembers)
                {
                    var teamMemberAttachment =
                        await mediator.Send(new GetTeamMemberAttachmentByTeamMemberIdQuery(teamMember.Id));

                    getDepartmentDto.HealthDepartmentManagers.TeamMembers =
                    [
                        new DepartmentDoctorTeamMembersDto()
                        {
                            FirstName = teamMember.FirstName,
                            LastName = teamMember.LastName,
                            Treatment = teamMember.Treatment,
                            Picture = teamMemberAttachment.Content
                        }
                    ];
                }
            }

            var countryCodes = await mediator.Send(new GetCountryCodesQuery());

            getDepartmentDto.TriageFormBasicData = new DepartmentTriageFormBasicDataDto()
            {
                CountryCodes = countryCodes.Codes,
            };

            return getDepartmentDto;
        }
    }
}