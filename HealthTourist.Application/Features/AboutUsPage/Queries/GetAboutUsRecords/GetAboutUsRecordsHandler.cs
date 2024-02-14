using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public class GetAboutUsRecordsHandler(IAboutUsRepository aboutUsRepository, IMapperBase mapper)
    : IRequestHandler<GetAboutUsRecordsQuery, List<GetAboutUsRecordsDto>>
{
    #region Handler

    public async Task<List<GetAboutUsRecordsDto>> Handle(GetAboutUsRecordsQuery request, CancellationToken cancellationToken)
    {
        // Fetch About Us All Records from database
        var aboutUsRecords = await aboutUsRepository.GetAllAsync();

        // TODO check fetched records for null
        
        // Map About Us All Records to list of required result
        var result = mapper.Map<List<GetAboutUsRecordsDto>>(aboutUsRecords);

        // Return result
        return result;
    }

    #endregion
}