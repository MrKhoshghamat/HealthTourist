using AutoMapper;
using HealthTourist.Application.Features.Main.InvoiceCost.Queries.GetInvoiceCostDetails;
using HealthTourist.Application.Features.Main.InvoiceCost.Queries.GetInvoiceCosts;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class InvoiceCostProfile : Profile
{
    public InvoiceCostProfile()
    {
        CreateMap<InvoiceCost, GetInvoiceCostsDto>().ReverseMap();
        CreateMap<InvoiceCost, GetInvoiceCostDetailsDto>().ReverseMap();
    }
}