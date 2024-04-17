using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.AirLine.Commands.CreateAirLine;
using HealthTourist.Application.Features.Main.AirLine.Commands.DeleteAirLine;
using HealthTourist.Application.Features.Main.AirLine.Commands.UpdateAirLine;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class AirLineController(IMediator mediator, IAppLogger<AirLine> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateAirLineCommand, int>> CreateAirLine(
            CreateAirLineCommand airLine)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateAirLineCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (airLine == null)
                    throw new ArgumentNullException(nameof(airLine), "AirLine object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(airLine);

                // Update postApiResult
                apiResult.Data = airLine;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("AirLine created successfully: {@airLine}", airLine);
            }
            catch (Exception ex)
            {
                // Log error
                if (airLine != null)
                    logger.LogError(ex, "Error occurred while creating airLine: {@airLine}", airLine);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateAirLineCommand, Unit>> UpdateAirLine(
            UpdateAirLineCommand airLine)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateAirLineCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (airLine == null)
                    throw new ArgumentNullException(nameof(airLine), "AirLine object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(airLine);

                // Update postApiResult
                apiResult.Data = airLine;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("AirLine updated successfully: {@airLine}", airLine);
            }
            catch (Exception ex)
            {
                // Log error
                if (airLine != null)
                    logger.LogError(ex, "Error occurred while updating airLine: {@airLine}", airLine);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteAirLineCommand, Unit>> DeleteAirLine(
            DeleteAirLineCommand airLine)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteAirLineCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (airLine == null)
                    throw new ArgumentNullException(nameof(airLine), "AirLine object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(airLine);

                // Update postApiResult
                apiResult.Data = airLine;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("AirLine deleted successfully: {@airLine}", airLine);
            }
            catch (Exception ex)
            {
                // Log error
                if (airLine != null)
                    logger.LogError(ex, "Error occurred while deleting airLine: {@airLine}", airLine);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteAirLineByIdCommand, Unit>> DeleteAirLine(
            DeleteAirLineByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteAirLineByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "id object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("AirLine deleted successfully: {@airLine}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting airLine: {@airLine}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}