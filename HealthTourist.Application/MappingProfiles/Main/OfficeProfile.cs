using AutoMapper;
using HealthTourist.Application.Features.Main.Office.Queries.GetOfficeDetails;
using HealthTourist.Application.Features.Main.Office.Queries.GetOffices;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class OfficeProfile : Profile
{
    public OfficeProfile()
    {
        CreateMap<Office, GetOfficesDto>().ReverseMap();
        CreateMap<Office, GetOfficeDetailsDto>().ReverseMap();
    }
}