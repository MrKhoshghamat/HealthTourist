using AutoMapper;
using HealthTourist.Application.Features.Triage.Commands.CreatePatient;
using HealthTourist.Application.Features.Triage.Commands.UpdatePatient;
using HealthTourist.Domain.Account;

namespace HealthTourist.Application.MappingProfiles.Triage;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, CreatePatientCommand>()
            .ForMember(dest =>
                dest.FirstName, opt =>
                opt.MapFrom(src => src.FirstName))
            .ForMember(dest =>
                dest.LastName, opt =>
                opt.MapFrom(src => src.LastName))
            .ForMember(dest =>
                dest.BirthDate, opt =>
                opt.MapFrom(src => src.BirthDate))
            .ForMember(dest =>
                dest.Gender, opt =>
                opt.MapFrom(src => src.Gender))
            .ForMember(dest =>
                dest.PhoneNumber, opt =>
                opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest =>
                dest.Email, opt =>
                opt.MapFrom(src => src.Email))
            .ForMember(dest =>
                dest.Address, opt =>
                opt.MapFrom(src => src.Address)).ReverseMap();
        
        CreateMap<Person, UpdatePatientCommand>()
            .ForMember(dest =>
                dest.FirstName, opt =>
                opt.MapFrom(src => src.FirstName))
            .ForMember(dest =>
                dest.LastName, opt =>
                opt.MapFrom(src => src.LastName))
            .ForMember(dest =>
                dest.BirthDate, opt =>
                opt.MapFrom(src => src.BirthDate))
            .ForMember(dest =>
                dest.Gender, opt =>
                opt.MapFrom(src => src.Gender))
            .ForMember(dest =>
                dest.PhoneNumber, opt =>
                opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest =>
                dest.Email, opt =>
                opt.MapFrom(src => src.Email))
            .ForMember(dest =>
                dest.Address, opt =>
                opt.MapFrom(src => src.Address)).ReverseMap();
    }
}