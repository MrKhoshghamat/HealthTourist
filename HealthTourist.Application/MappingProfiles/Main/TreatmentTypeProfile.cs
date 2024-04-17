using AutoMapper;
using HealthTourist.Application.Features.Main.TreatmentType.Commands.CreateTreatmentType;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeDetails;
using HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypes;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class TreatmentTypeProfile : Profile
{
    public TreatmentTypeProfile()
    {
        CreateMap<TreatmentType, GetTreatmentTypesDto>().ReverseMap();
        CreateMap<TreatmentType, GetTreatmentTypeDetailsDto>().ReverseMap();
        CreateMap<TreatmentType, CreateTreatmentTypeCommand>().ReverseMap();
    }
}