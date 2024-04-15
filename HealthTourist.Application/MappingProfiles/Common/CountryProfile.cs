using AutoMapper;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountries;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountryCodes;
using HealthTourist.Application.Features.Common.Country.Queries.GetCountryDetails;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Common;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<Country, GetCountriesDto>().ReverseMap();
        CreateMap<Country, GetCountryDetailsDto>().ReverseMap();

        CreateMap<Country, GetCountryCodesDto>()
            .ForMember(dest =>
                dest.Codes, opt =>
                opt.MapFrom(src => src.Code)).ReverseMap();
    }
}