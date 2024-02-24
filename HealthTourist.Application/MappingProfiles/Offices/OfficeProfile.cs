using AutoMapper;
using HealthTourist.Application.Features.Offices.Commands.CreateOffice;
using HealthTourist.Application.Features.Offices.Commands.DeleteOffice;
using HealthTourist.Application.Features.Offices.Commands.UpdateOffice;
using HealthTourist.Application.Features.Offices.Queries.GetOfficeDetails;
using HealthTourist.Application.Features.Offices.Queries.GetOffices;
using HealthTourist.Domain.AboutUsPage;

namespace HealthTourist.Application.MappingProfiles.Offices;

public class OfficeProfile : Profile
{
    public OfficeProfile()
    {
        CreateMap<Office, GetOfficesDto>().ReverseMap();
        CreateMap<Office, GetOfficeDetailsDto>().ReverseMap();

        CreateMap<Office, CreateOfficeCommand>().ReverseMap();
        CreateMap<Office, UpdateOfficeCommand>().ReverseMap();
        CreateMap<Office, DeleteOfficeCommand>().ReverseMap();
    }
}