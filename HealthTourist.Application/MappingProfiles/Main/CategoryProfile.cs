using AutoMapper;
using HealthTourist.Application.Features.Main.Category.Queries.GetCategories;
using HealthTourist.Application.Features.Main.Category.Queries.GetCategoryDetails;
using HealthTourist.Domain.Main;

namespace HealthTourist.Application.MappingProfiles.Main;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, GetCategoriesDto>().ReverseMap();
        CreateMap<Category, GetCategoryDetailsDto>().ReverseMap();
    }
}