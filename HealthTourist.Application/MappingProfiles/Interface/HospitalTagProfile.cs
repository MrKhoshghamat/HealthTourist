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
                dest.TagId, opt =>
                opt.MapFrom(src => src.TagId))
            .ForMember(dest =>
                dest.Title, opt =>
                opt.MapFrom(src => src.Tag.Title)).ReverseMap();
    }
}