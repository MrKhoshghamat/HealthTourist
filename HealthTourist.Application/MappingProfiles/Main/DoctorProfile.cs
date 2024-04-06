using AutoMapper;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctorDetails;
using HealthTourist.Application.Features.Main.Doctor.Queries.GetDoctors;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<Doctor, GetDoctorsDto>().ReverseMap();
        CreateMap<Doctor, GetDoctorDetailsDto>().ReverseMap();
    }
}