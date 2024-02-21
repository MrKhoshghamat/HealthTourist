using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Common.Constants.AboutUs;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;

public class GetAboutUsRecordsQueryHandler(
    IAboutUsRepository aboutUsRepository,
    IMapper mapper,
    IAppLogger<GetAboutUsRecordsQueryHandler> logger)
    : IRequestHandler<GetAboutUsRecordsQuery, List<GetAboutUsRecordsDto>>
{
    #region Handler

    public async Task<List<GetAboutUsRecordsDto>> Handle(GetAboutUsRecordsQuery request,
        CancellationToken cancellationToken)
    {
        // Fetch About Us All Records from database
        var aboutUsRecords = await aboutUsRepository.GetAllAsync(x => !x.IsDeleted);

        // Check fetched records for null
        if (aboutUsRecords == null) throw new NotFoundException(nameof(List<AboutUs>), request);

        // Map About Us All Records to list of required result
        var result = mapper.Map<List<GetAboutUsRecordsDto>>(aboutUsRecords);

        // Logging
        logger.LogInformation(AboutUsLogConstants.GetAboutUsRecordsQueryLogMessage);

        // Return result
        return result;
    }

    #endregion
}