using AutoMapper;
using HealthTourist.Application.Features.Main.Patient.Queries.GetPatientDetails;
using HealthTourist.Application.Features.Main.Patient.Queries.GetPatients;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, GetPatientsDto>().ReverseMap();
        CreateMap<Patient, GetPatientDetailsDto>().ReverseMap();
    }
}