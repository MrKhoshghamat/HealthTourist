using HealthTourist.Api.Models.Hotel.Main;
using HealthTourist.Api.Models.Hotel.Sub;
using HealthTourist.Application.Features.Common.City.Queries.GetCities;
using HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;
using HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentsByHotelId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelsByCityName;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelTagsByHotelId;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenAttachmentsByCityName;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class HotelController(ISender mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetHotelDto> GetHotel(string cityName)
        {
            var getHotelDto = new GetHotelDto();

            var cities = await mediator.Send(new GetCitiesQuery());
            var hotels = await mediator.Send(new GetHotelsByCityNameQuery(cityName));

            foreach (var city in cities)
            {
                var cityAttachment = await mediator.Send(new GetCityAttachmentByCityIdQuery(city.Id));

                getHotelDto.Cities =
                [
                    new HotelCityDto()
                    {
                        Name = city.Name,
                        Title = city.Title,
                        picture = cityAttachment.Content
                    }
                ];
            }

            foreach (var hotel in hotels)
            {
                var hotelTags = await mediator.Send(new GetHotelTagsByHotelIdQuery(hotel.Id));
                var hotelAttachments = await mediator.Send(new GetHotelAttachmentsByHotelIdQuery(hotel.Id));

                getHotelDto.Hotels =
                [
                    new HotelCityHotelDto()
                    {
                        Name = hotel.Name,
                        Title = hotel.Title,
                        Description = hotel.Description,
                        HotelRank = hotel.HotelRank.Title,
                        HotelType = hotel.HotelRank.HotelType.Title,
                        Pictures = hotelAttachments.Contents,
                        Tags = hotelTags.TagTitles
                    }
                ];
            }

            var sightseenCategories = await mediator.Send(new GetSightseenCategoriesQuery());
            var sightseenCategoriesNameList = sightseenCategories
                .Select(sightseenCategory => sightseenCategory.Category.Title).ToList();
            var sightseenAttachments = await mediator.Send(new GetSightseenAttachmentsByCityNameQuery(cityName));

            foreach (var sightseenAttachment in sightseenAttachments)
            {
                getHotelDto.CitySightseens =
                [
                    new HotelCitySightseenDto()
                    {
                        SightseenCategories = sightseenCategoriesNameList,
                        Pictures =
                        [
                            new HotelCitySightseenPictureDto()
                            {
                                Title = sightseenAttachment.Title,
                                Picture = sightseenAttachment.Content
                            }
                        ]
                    }
                ];
            }

            return getHotelDto;
        }
    }
}