using AutoMapper;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalDetails;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HospitalProfile : Profile
{
    public HospitalProfile()
    {
        CreateMap<Hospital, GetHospitalsDto>().ReverseMap();
        CreateMap<Hospital, GetHospitalDetailsDto>().ReverseMap();
    }
}