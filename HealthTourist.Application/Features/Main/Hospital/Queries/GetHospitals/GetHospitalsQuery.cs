using MediatR;

namespace HealthTourist.Application.Features.Main.Hospital.Queries.GetHospitals;

public record GetHospitalsQuery : IRequest<List<GetHospitalsDto>>; 
