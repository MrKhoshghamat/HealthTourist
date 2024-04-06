using AutoMapper;
using HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypeDetails;
using HealthTourist.Application.Features.Main.HospitalType.Queries.GetHospitalTypes;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class HospitalTypeProfile : Profile
{
    public HospitalTypeProfile()
    {
        CreateMap<HospitalType, GetHospitalTypesDto>().ReverseMap();
        CreateMap<HospitalType, GetHospitalTypeDetailsDto>().ReverseMap();
    }
}