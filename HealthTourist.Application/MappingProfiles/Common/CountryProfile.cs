using AutoMapper;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountries;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountryDetails;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Common;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<Country, GetCountriesDto>().ReverseMap();
        CreateMap<Country, GetCountryDetailsDto>().ReverseMap();
    }
}