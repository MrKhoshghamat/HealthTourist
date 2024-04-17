using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.OfficeManager.Commands.CreateOfficeManager;
using HealthTourist.Application.Features.Main.OfficeManager.Commands.DeleteOfficeManager;
using HealthTourist.Application.Features.Main.OfficeManager.Commands.UpdateOfficeManager;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class OfficeManagerController(IMediator mediator, IAppLogger<OfficeManager> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateOfficeManagerCommand, long>> CreateOfficeManager(
            CreateOfficeManagerCommand officeManager)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateOfficeManagerCommand, long>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (officeManager == null)
                    throw new ArgumentNullException(nameof(officeManager), "OfficeManager object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(officeManager);

                // Update postApiResult
                apiResult.Data = officeManager;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("OfficeManager created successfully: {@officeManager}", officeManager);
            }
            catch (Exception ex)
            {
                // Log error
                if (officeManager != null)
                    logger.LogError(ex, "Error occurred while creating OfficeManager: {@officeManager}", officeManager);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateOfficeManagerCommand, Unit>> UpdateOfficeManager(
            UpdateOfficeManagerCommand officeManager)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateOfficeManagerCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (officeManager == null)
                    throw new ArgumentNullException(nameof(officeManager), "OfficeManager object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(officeManager);

                // Update postApiResult
                apiResult.Data = officeManager;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("OfficeManager updated successfully: {@officeManager}", officeManager);
            }
            catch (Exception ex)
            {
                // Log error
                if (officeManager != null)
                    logger.LogError(ex, "Error occurred while updating office: {@officeManager}", officeManager);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteOfficeManagerCommand, Unit>> DeleteOfficeManager(
            DeleteOfficeManagerCommand officeManager)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteOfficeManagerCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (officeManager == null)
                    throw new ArgumentNullException(nameof(officeManager), "OfficeManager object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(officeManager);

                // Update postApiResult
                apiResult.Data = officeManager;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("OfficeManager deleted successfully: {@officeManager}", officeManager);
            }
            catch (Exception ex)
            {
                // Log error
                if (officeManager != null)
                    logger.LogError(ex, "Error occurred while deleting office: {@officeManager}", officeManager);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteOfficeManagerByIdCommand, Unit>> DeleteOfficeManager(
            DeleteOfficeManagerByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteOfficeManagerByIdCommand, Unit>
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
                logger.LogInformation("OfficeManager deleted successfully: {@officeManager}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting OfficeManager: {@officeManager}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}