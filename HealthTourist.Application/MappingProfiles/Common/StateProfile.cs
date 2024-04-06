using AutoMapper;
using HealthTourist.Application.Features.Common.State.Queries.GetStateDetails;
using HealthTourist.Application.Features.Common.State.Queries.GetStates;
using HealthTourist.Domain.Common;

namespace HealthTourist.Application.MappingProfiles.Common;

public class StateProfile : Profile
{
    public StateProfile()
    {
        CreateMap<State, GetStatesDto>().ReverseMap();
        CreateMap<State, GetStateDetailsDto>().ReverseMap();
    }
}