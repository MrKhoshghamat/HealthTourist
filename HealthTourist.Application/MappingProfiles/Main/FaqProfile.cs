using AutoMapper;
using HealthTourist.Application.Features.Main.Faq.Queries.GetFaqDetails;
using HealthTourist.Application.Features.Main.Faq.Queries.GetFaqs;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class FaqProfile : Profile
{
    public FaqProfile()
    {
        CreateMap<Faq, GetFaqsDto>().ReverseMap();
        CreateMap<Faq, GetFaqDetailsDto>().ReverseMap();
    }
}