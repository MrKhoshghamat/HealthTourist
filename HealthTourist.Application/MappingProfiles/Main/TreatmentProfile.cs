using AutoMapper;
using HealthTourist.Application.Features.Main.Treatment.Queries.GetTreatmentDetails;
using HealthTourist.Application.Features.Main.Treatment.Queries.GetTreatments;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TreatmentProfile : Profile
{
    public TreatmentProfile()
    {
        CreateMap<Treatment, GetTreatmentsDto>().ReverseMap();
        CreateMap<Treatment, GetTreatmentDetailsDto>().ReverseMap();
    }
}