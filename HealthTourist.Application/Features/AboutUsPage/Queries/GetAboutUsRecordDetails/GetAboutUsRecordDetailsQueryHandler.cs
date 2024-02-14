using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using MediatR;

namespace HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;

public class
    GetAboutUsRecordDetailsQueryHandler(IAboutUsRepository aboutUsRepository, IMapperBase mapper)
    : IRequestHandler<GetAboutUsRecordDetailsQuery, GetAboutUsRecordDetailsDto>
{
    #region Handler

    public async Task<GetAboutUsRecordDetailsDto> Handle(GetAboutUsRecordDetailsQuery request,
        CancellationToken cancellationToken)
    {
        // Fetch About Us Record Details from database
        var aboutUsRecordDetails = await aboutUsRepository.FindAsync(request.Id);

        // TODO check fetched record for null

        // Map About Us Record Details to required result
        var result = mapper.Map<GetAboutUsRecordDetailsDto>(aboutUsRecordDetails);

        // Return result
        return result;
    }

    #endregion
}