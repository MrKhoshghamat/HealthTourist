using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public class GetAboutUsRecordsQueryHandler(IAboutUsRepository aboutUsRepository, IMapperBase mapper)
    : IRequestHandler<GetAboutUsRecordsQuery, List<GetAboutUsRecordsDto>>
{
    #region Handler

    public async Task<List<GetAboutUsRecordsDto>> Handle(GetAboutUsRecordsQuery request,
        CancellationToken cancellationToken)
    {
        // Fetch About Us All Records from database
        var aboutUsRecords = await aboutUsRepository.GetAllAsync();

        // Check fetched records for null
        if (aboutUsRecords == null) throw new NotFoundException(nameof(List<AboutUs>), request);

        // Map About Us All Records to list of required result
        var result = mapper.Map<List<GetAboutUsRecordsDto>>(aboutUsRecords);

        // Return result
        return result;
    }

    #endregion
}