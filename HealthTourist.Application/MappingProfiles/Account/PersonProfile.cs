using AutoMapper;
using HealthTourist.Application.Features.Account.Person.Queries.GetPersonDetails;
using HealthTourist.Application.Features.Account.Person.Queries.GetPersons;
using HealthTourist.Domain.Account;

namespace HealthTourist.Application.MappingProfiles.Account;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, GetPersonsDto>().ReverseMap();
        CreateMap<Person, GetPersonDetailsDto>().ReverseMap();
    }
}