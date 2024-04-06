using AutoMapper;
using HealthTourist.Application.Features.Main.Guest.Queries.GetGuestDetails;
using HealthTourist.Application.Features.Main.Guest.Queries.GetGuests;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class GuestProfile : Profile
{
    public GuestProfile()
    {
        CreateMap<Guest, GetGuestsDto>().ReverseMap();
        CreateMap<Guest, GetGuestDetailsDto>().ReverseMap();
    }
}