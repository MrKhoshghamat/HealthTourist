using AutoMapper;
using HealthTourist.Application.Features.Main.OfficeManager.Queries.GetOfficeManagerDetails;
using HealthTourist.Application.Features.Main.OfficeManager.Queries.GetOfficeManagers;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class OfficeManagerProfile : Profile
{
    public OfficeManagerProfile()
    {
        CreateMap<OfficeManager, GetOfficeManagersDto>().ReverseMap();
        CreateMap<OfficeManager, GetOfficeManagerDetailsDto>().ReverseMap();
    }
}