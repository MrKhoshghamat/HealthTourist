using AutoMapper;
using HealthTourist.Application.Features.Triage.Commands.CreatePatient;
using HealthTourist.Application.Features.Triage.Queries.GetPatientDetails;
using HealthTourist.Application.Features.Triage.Queries.GetPatients;
using HealthTourist.Domain.Department;

namespace HealthTourist.Application.MappingProfiles.Triage;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, GetPatientsDto>()
            .ForMember(dest =>
                dest.FirstName, opt =>
                opt.MapFrom(src =>
                    src.Person.FirstName))
            .ForMember(dest =>
                dest.LastName, opt =>
                opt.MapFrom(src =>
                    src.Person.LastName))
            .ForMember(dest =>
                dest.BirthDate, opt =>
                opt.MapFrom(src =>
                    src.Person.BirthDate))
            .ForMember(dest =>
                dest.Gender, opt =>
                opt.MapFrom(src =>
                    src.Person.Gender))
            .ForMember(dest =>
                dest.PhoneNumber, opt =>
                opt.MapFrom(src =>
                    src.Person.PhoneNumber))
            .ForMember(dest =>
                dest.Email, opt =>
                opt.MapFrom(src =>
                    src.Person.Email))
            .ForMember(dest =>
                dest.Address, opt =>
                opt.MapFrom(src =>
                    src.Person.Address)).ReverseMap();
        
        CreateMap<Patient, GetPatientDetailsDto>()
            .ForMember(dest =>
                dest.FirstName, opt =>
                opt.MapFrom(src =>
                    src.Person.FirstName))
            .ForMember(dest =>
                dest.LastName, opt =>
                opt.MapFrom(src =>
                    src.Person.LastName))
            .ForMember(dest =>
                dest.BirthDate, opt =>
                opt.MapFrom(src =>
                    src.Person.BirthDate))
            .ForMember(dest =>
                dest.Gender, opt =>
                opt.MapFrom(src =>
                    src.Person.Gender))
            .ForMember(dest =>
                dest.PhoneNumber, opt =>
                opt.MapFrom(src =>
                    src.Person.PhoneNumber))
            .ForMember(dest =>
                dest.Email, opt =>
                opt.MapFrom(src =>
                    src.Person.Email))
            .ForMember(dest =>
                dest.Address, opt =>
                opt.MapFrom(src =>
                    src.Person.Address)).ReverseMap();
        
        CreateMap<Patient, CreatePatientCommand>()
            .ForMember(dest =>
                dest.FirstName, opt =>
                opt.MapFrom(src =>
                    src.Person.FirstName))
            .ForMember(dest =>
                dest.LastName, opt =>
                opt.MapFrom(src =>
                    src.Person.LastName))
            .ForMember(dest =>
                dest.BirthDate, opt =>
                opt.MapFrom(src =>
                    src.Person.BirthDate))
            .ForMember(dest =>
                dest.Gender, opt =>
                opt.MapFrom(src =>
                    src.Person.Gender))
            .ForMember(dest =>
                dest.PhoneNumber, opt =>
                opt.MapFrom(src =>
                    src.Person.PhoneNumber))
            .ForMember(dest =>
                dest.Email, opt =>
                opt.MapFrom(src =>
                    src.Person.Email))
            .ForMember(dest =>
                dest.Address, opt =>
                opt.MapFrom(src =>
                    src.Person.Address)).ReverseMap();
    }
}