using AutoMapper;
using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecords;
using HealthTourist.Application.MappingProfiles.AboutUsPage;
using HealthTourist.Application.Test.Mocks;
using Moq;
using Shouldly;

namespace HealthTourist.Application.Test.Features.AboutUsPage.Queries;

public class GetAboutUsRecordsQueryHandlerTests
{
    private readonly Mock<IAboutUsRepository> _mockRepo;
    private readonly IMapper _mapper;
    private readonly Mock<IAppLogger<GetAboutUsRecordsQueryHandler>> _mockAppLogger;

    public GetAboutUsRecordsQueryHandlerTests()
    {
        _mockRepo = MockAboutUsRepository.GetAboutUsRecordsMockAboutUsRepository();
        var mapperConfig = new MapperConfiguration(c => { c.AddProfile<AboutUsProfile>(); });
        _mapper = mapperConfig.CreateMapper();
        _mockAppLogger = new Mock<IAppLogger<GetAboutUsRecordsQueryHandler>>();
    }

    [Fact]
    public async Task GetAboutUsRecordsTest()
    {
        var handler = new GetAboutUsRecordsQueryHandler(_mockRepo.Object, _mapper, _mockAppLogger.Object);

        var result = await handler.Handle(new GetAboutUsRecordsQuery(), CancellationToken.None);
        result.ShouldBeOfType<IReadOnlyList<GetAboutUsRecordsDto>>();
        result.Count.ShouldBe(3);
    }
}