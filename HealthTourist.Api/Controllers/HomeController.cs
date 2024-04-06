using HealthTourist.Api.Models.Home;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotels;
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

            // getHomeDto.FaqTypes = faqTypes;
            // getHomeDto.TreatmentTypes = treatmentTypes;
            // getHomeDto.Doctors = doctors;
            // getHomeDto.Hospitals = hospitals;
            // getHomeDto.Hotels = hotels;

            return getHomeDto;
        }
    }
}