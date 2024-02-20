using HealthTourist.Application.Contracts.AboutUsPage;
using HealthTourist.Common.Enumerations.AboutUs;
using HealthTourist.Domain.AboutUsPage;
using Moq;

namespace HealthTourist.Application.Test.Mocks;

public class MockAboutUsRepository
{
    public static Mock<IAboutUsRepository> GetAboutUsRecordsMockAboutUsRepository()
    {
        var aboutUsRecords = new List<AboutUs>
        {
            new AboutUs
            {
                Title = "Our Company1",
                Description = "We are a leading company in our industry.",
                TeamMembers = [],
                Offices = []
            },
            new AboutUs
            {
                Title = "Our Company2",
                Description = "We are a leading company in our industry.",
                TeamMembers = [],
                Offices = []
            },
            new AboutUs
            {
                Title = "Our Company3",
                Description = "We are a leading company in our industry.",
                TeamMembers = [],
                Offices = []
            }
        };

        var mockRepo = new Mock<IAboutUsRepository>();
        mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(aboutUsRecords);
        mockRepo.Setup(r => r.CreateAsync(It.IsAny<AboutUs>()))
            .Returns((AboutUs aboutUs) =>
            {
                aboutUsRecords.Add(aboutUs);
                return Task.CompletedTask;
            });

        return mockRepo;
    }
}