using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.AboutUsPage;
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

        // Check fetched record for null
        if (aboutUsRecordDetails == null) throw new NotFoundException(nameof(AboutUs), request.Id);

        // Map About Us Record Details to required result
        var result = mapper.Map<GetAboutUsRecordDetailsDto>(aboutUsRecordDetails);

        // Return result
        return result;
    }

    #endregion
}