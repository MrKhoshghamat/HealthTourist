using AutoMapper;
using HealthTourist.Application.Features.Common.City.Queries.GetCities;
using HealthTourist.Application.Features.Common.City.Queries.GetCityDetails;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Common;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, GetCitiesDto>().ReverseMap();
        CreateMap<City, GetCityDetailsDto>().ReverseMap();
    }
}