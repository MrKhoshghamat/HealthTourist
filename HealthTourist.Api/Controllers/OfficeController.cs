using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.Office.Commands.CreateOffice;
using HealthTourist.Application.Features.Main.Office.Commands.DeleteOffice;
using HealthTourist.Application.Features.Main.Office.Commands.UpdateOffice;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class OfficeController(IMediator mediator, IAppLogger<Office> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateOfficeCommand, int>> CreateOffice(CreateOfficeCommand office)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateOfficeCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (office == null)
                    throw new ArgumentNullException(nameof(office), "office object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(office);

                // Update postApiResult
                apiResult.Data = office;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("office created successfully: {@office}", office);
            }
            catch (Exception ex)
            {
                // Log error
                if (office != null)
                    logger.LogError(ex, "Error occurred while creating office: {@office}", office);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateOfficeCommand, Unit>> UpdateOffice(UpdateOfficeCommand office)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateOfficeCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (office == null)
                    throw new ArgumentNullException(nameof(office), "office object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(office);

                // Update postApiResult
                apiResult.Data = office;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("office updated successfully: {@office}", office);
            }
            catch (Exception ex)
            {
                // Log error
                if (office != null)
                    logger.LogError(ex, "Error occurred while updating office: {@office}", office);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteOfficeCommand, Unit>> DeleteOffice(DeleteOfficeCommand office)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteOfficeCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (office == null)
                    throw new ArgumentNullException(nameof(office), "office object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(office);

                // Update postApiResult
                apiResult.Data = office;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("office deleted successfully: {@office}", office);
            }
            catch (Exception ex)
            {
                // Log error
                if (office != null)
                    logger.LogError(ex, "Error occurred while deleting office: {@office}", office);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteOfficeByIdCommand, Unit>> DeleteOffice(
            DeleteOfficeByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteOfficeByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "id cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("office deleted successfully: {@office}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting office: {@office}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}