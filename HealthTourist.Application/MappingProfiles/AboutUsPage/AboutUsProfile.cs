using AutoMapper;
using HealthTourist.Application.Features.AboutUsPage.Commands.CreateAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Commands.UpdateAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;
using HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;
using HealthTourist.Domain.AboutUsPage;

namespace HealthTourist.Application.MappingProfiles.AboutUsPage;

public class AboutUsProfile : Profile
{
    public AboutUsProfile()
    {
        CreateMap<AboutUs, GetAboutUsRecordsDto>().ReverseMap();
        CreateMap<AboutUs, GetAboutUsRecordDetailsDto>().ReverseMap();

        CreateMap<AboutUs, CreateAboutUsCommand>().ReverseMap();
        CreateMap<AboutUs, UpdateAboutUsCommand>().ReverseMap();
        CreateMap<AboutUs, DeleteAboutUsCommand>().ReverseMap();
    }
}