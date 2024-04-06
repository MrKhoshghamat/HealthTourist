using AutoMapper;
using HealthTourist.Application.Features.Main.Invoice.Queries.GetInvoiceDetails;
using HealthTourist.Application.Features.Main.Invoice.Queries.GetInvoices;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class InvoiceProfile : Profile
{
    public InvoiceProfile()
    {
        CreateMap<Invoice, GetInvoicesDto>().ReverseMap();
        CreateMap<Invoice, GetInvoiceDetailsDto>().ReverseMap();
    }
}