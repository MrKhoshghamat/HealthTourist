using AutoMapper;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorSocialMediasByDoctorId;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.MappingProfiles.Interface;

public class DoctorSocialMediaProfile : Profile
{
    public DoctorSocialMediaProfile()
    {
        CreateMap<DoctorSocialMedia, GetDoctorSocialMediasByDoctorIdDto>()
            .ForMember(dest =>
                    dest.DoctorId,
                opt =>
                    opt.MapFrom(src => src.DoctorId))
            .ForMember(dest =>
                    dest.Links,
                opt =>
                    opt.MapFrom(src => src.Link))
            .ForMember(dest =>
                    dest.SocialMediae,
                opt =>
                    opt.MapFrom(src => src.SocialMedia)).ReverseMap();
    }
}