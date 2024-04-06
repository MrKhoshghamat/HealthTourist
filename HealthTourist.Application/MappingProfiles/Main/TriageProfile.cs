using AutoMapper;
using HealthTourist.Application.Features.Main.Triage.Queries.GetTriageDetails;
using HealthTourist.Application.Features.Main.Triage.Queries.GetTriages;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TriageProfile : Profile
{
    public TriageProfile()
    {
        CreateMap<Triage, GetTriagesDto>().ReverseMap();
        CreateMap<Triage, GetTriageDetailsDto>().ReverseMap();
    }
}