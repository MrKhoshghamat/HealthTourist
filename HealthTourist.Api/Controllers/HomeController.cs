using HealthTourist.Api.Models.Home.Main;
using HealthTourist.Api.Models.Home.Sub;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorAttachmentByDoctorId;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class HomeController(ISender mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetHomeDto> GetHome()
        {
            var getHomeDto = new GetHomeDto();

            var faqTypes = await mediator.Send(new GetFaqTypesQuery());
            var treatmentTypes = await mediator.Send(new GetTreatmentTypesQuery());
            var doctors = await mediator.Send(new GetDoctorsQuery());
            var hospitals = await mediator.Send(new GetHospitalsQuery());
            var hotels = await mediator.Send(new GetHotelsQuery());

            foreach (var faqType in faqTypes)
            {
                var faqTypeIcon = await mediator.Send(new GetFaqTypeIconByFaqTypeIdQuery(faqType.Id));
                var selectedFaqTypeIcon =
                    await mediator.Send(new GetFaqTypeSelectedIconByFaqTypeIdQuery(faqType.Id, true));

                getHomeDto.FaqTypes =
                [
                    new HomeFaqTypesDto()
                    {
                        Name = faqType.Name,
                        Title = faqType.Title,
                        Description = faqType.Description,
                        Priority = faqType.Priority,
                        Icon = faqTypeIcon.Content,
                        SelectedIcon = selectedFaqTypeIcon.Content
                    }
                ];
            }

            foreach (var treatmentType in treatmentTypes)
            {
                var treatmentTypeIcon =
                    await mediator.Send(new GetTreatmentTypeIconByTreatmentTypeIdQuery(treatmentType.Id));

                getHomeDto.TreatmentTypes =
                [
                    new HomeTreatmentTypesDto()
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

                getHomeDto.Doctors =
                [
                    new HomeDoctorsDto()
                    {
                        FirstName = doctor.Person.FirstName,
                        LastName = doctor.Person.LastName,
                        Treatment = doctor.Treatment.Title,
                        SocialMedias = doctorSocialMedia.SocialMediae,
                        SocialMediaLinks = doctorSocialMedia.Links,
                        Picture = doctorAttachment.Content
                    }
                ];
            }

            foreach (var hospital in hospitals)
            {
                var hospitalTag = await mediator.Send(new GetHospitalTagsByHospitalIdQuery(hospital.Id));
                var hospitalAttachment = await mediator.Send(new GetHospitalAttachmentByHospitalIdQuery(hospital.Id));

                getHomeDto.Hospitals =
                [
                    new HomeHospitalsDto()
                    {
                        Name = hospital.Name,
                        Title = hospital.Title,
                        Description = hospital.Description,
                        Tags = hospitalTag.Tags,
                        Pictures = hospitalAttachment.Contents
                    }
                ];
            }

            foreach (var hotel in hotels)
            {
                var hotelAttachment = await mediator.Send(new GetHotelAttachmentByHotelIdQuery(hotel.Id));

                getHomeDto.Hotels =
                [
                    new HomeHotelsDto()
                    {
                        Name = hotel.Name,
                        Title = hotel.Title,
                        Description = hotel.Description,
                        Picture = hotelAttachment.Content
                    }
                ];
            }

            return getHomeDto;
        }
    }
}