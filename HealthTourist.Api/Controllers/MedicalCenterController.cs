using HealthTourist.Api.Models.MedicalCenter.Main;
using HealthTourist.Api.Models.MedicalCenter.Sub;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalAttachmentByHospitalId;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentByHotelId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class MedicalCenterController(IMediator mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetMedicalCenterDto> GetMedicalCenter()
        {
            var getMedicalCenterDto = new GetMedicalCenterDto();

            var medicalCenters = await mediator.Send(new GetHospitalsQuery());
            var hotels = await mediator.Send(new GetHotelsQuery());

            foreach (var medicalCenter in medicalCenters)
            {
                getMedicalCenterDto.MedicalCentersNames.Add(medicalCenter.Title);

                var medicalCenterTags = await mediator.Send(new GetHospitalTagsByHospitalIdQuery(medicalCenter.Id));
                var medicalCenterPictures =
                    await mediator.Send(new GetHospitalAttachmentByHospitalIdQuery(medicalCenter.Id));
                var medicalCenterPicturesFileContentResults = medicalCenterPictures
                    .Contents.Select(content => File(content, "img/jpeg")).ToList();

                getMedicalCenterDto.MedicalCenters =
                [
                    new MedicalCenterHospitalDto()
                    {
                        Name = medicalCenter.Name,
                        Title = medicalCenter.Title,
                        Country = medicalCenter.City.State.Country.Title,
                        Description = medicalCenter.Description,
                        HospitalType = medicalCenter.HospitalType.Title,
                        Tags = medicalCenterTags.Tags,
                        Pictures = medicalCenterPicturesFileContentResults
                    }
                ];
            }

            foreach (var hotel in hotels)
            {
                var hotelAttachment = await mediator.Send(new GetHotelAttachmentByHotelIdQuery(hotel.Id));

                getMedicalCenterDto.Hotels =
                [
                    new MedicalCenterHotelDto()
                    {
                        Name = hotel.Name,
                        Title = hotel.Title,
                        Picture = File(hotelAttachment.Content, "img/jpeg")
                    }
                ];
            }

            return getMedicalCenterDto;
        }
    }
}