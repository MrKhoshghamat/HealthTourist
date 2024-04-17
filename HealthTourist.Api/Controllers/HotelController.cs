using System.Net;
using HealthTourist.Api.Models.Hotel.Main;
using HealthTourist.Api.Models.Hotel.Sub;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Common.City.Queries.GetCities;
using HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;
using HealthTourist.Application.Features.Interface.SightseenCategory.Queries.GetSightseenCategories;
using HealthTourist.Application.Features.Main.Hotel.Commands.CreateHotel;
using HealthTourist.Application.Features.Main.Hotel.Commands.DeleteHotel;
using HealthTourist.Application.Features.Main.Hotel.Commands.UpdateHotel;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentsByHotelId;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelsByCityName;
using HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelTagsByHotelId;
using HealthTourist.Application.Features.Main.Sightseen.Queries.GetSightseenAttachmentsByCityName;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class HotelController(ISender mediator, IAppLogger<Hotel> logger) : BaseController
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
                        picture = File(cityAttachment.Content, "img/jpeg")
                    }
                ];
            }

            foreach (var hotel in hotels)
            {
                var hotelTags = await mediator.Send(new GetHotelTagsByHotelIdQuery(hotel.Id));
                var hotelAttachments = await mediator.Send(new GetHotelAttachmentsByHotelIdQuery(hotel.Id));
                var hotelAttachmentsFileContentResults =
                    hotelAttachments.Contents.Select(content => File(content, "img/jpeg")).ToList();

                getHotelDto.Hotels =
                [
                    new HotelCityHotelDto()
                    {
                        Name = hotel.Name,
                        Title = hotel.Title,
                        Description = hotel.Description,
                        HotelRank = hotel.HotelRank.Title,
                        HotelType = hotel.HotelRank.HotelType.Title,
                        Pictures = hotelAttachmentsFileContentResults,
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
                                Picture = File(sightseenAttachment.Content, "img/jpeg")
                            }
                        ]
                    }
                ];
            }

            return getHotelDto;
        }

        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateHotelCommand, int>> CreateHotel(CreateHotelCommand hotel)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateHotelCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (hotel == null)
                    throw new ArgumentNullException(nameof(hotel), "Hotel object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hotel);

                // Update postApiResult
                apiResult.Data = hotel;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hotel created successfully: {@hotel}", hotel);
            }
            catch (Exception ex)
            {
                // Log error
                if (hotel != null)
                    logger.LogError(ex, "Error occurred while creating hotel: {@hotel}", hotel);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateHotelCommand, Unit>> UpdateHotel(UpdateHotelCommand hotel)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateHotelCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (hotel == null)
                    throw new ArgumentNullException(nameof(hotel), "Hotel object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hotel);

                // Update postApiResult
                apiResult.Data = hotel;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hotel updated successfully: {@hotel}", hotel);
            }
            catch (Exception ex)
            {
                // Log error
                if (hotel != null)
                    logger.LogError(ex, "Error occurred while updating hotel: {@hotel}", hotel);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHotelCommand, Unit>> DeleteHotel(DeleteHotelCommand hotel)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHotelCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (hotel == null)
                    throw new ArgumentNullException(nameof(hotel), "Hotel object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hotel);

                // Update postApiResult
                apiResult.Data = hotel;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hotel deleted successfully: {@hotel}", hotel);
            }
            catch (Exception ex)
            {
                // Log error
                if (hotel != null)
                    logger.LogError(ex, "Error occurred while deleting hotel: {@hotel}", hotel);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHotelByIdCommand, Unit>> DeleteHotel(
            DeleteHotelByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHotelByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "Hotel object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hotel deleted successfully: {@hotel}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting hotel: {@hotel}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}