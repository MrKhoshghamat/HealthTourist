using AutoMapper;
using HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitalTagsByHospitalId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class HospitalTagProfile : Profile
{
    public HospitalTagProfile()
    {
        CreateMap<HospitalTag, GetHospitalTagsByHospitalIdDto>()
            .ForMember(dest =>
                dest.HospitalId, opt =>
                opt.MapFrom(src => src.HospitalId))
            .ForMember(dest =>
                dest.Tags, opt =>
                opt.MapFrom(src => src.Tag.Title)).ReverseMap();
    }
}