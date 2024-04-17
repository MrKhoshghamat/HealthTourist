using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.HospitalType.Commands.CreateHospitalType;
using HealthTourist.Application.Features.Main.HospitalType.Commands.DeleteHospitalType;
using HealthTourist.Application.Features.Main.HospitalType.Commands.UpdateHospitalType;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class HospitalTypeController(IMediator mediator, IAppLogger<HospitalType> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateHospitalTypeCommand, int>> CreateHospitalType(
            CreateHospitalTypeCommand hospitalType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateHospitalTypeCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (hospitalType == null)
                    throw new ArgumentNullException(nameof(hospitalType), "HospitalType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospitalType);

                // Update postApiResult
                apiResult.Data = hospitalType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("HospitalType created successfully: {@hospitalType}", hospitalType);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospitalType != null)
                    logger.LogError(ex, "Error occurred while creating HospitalType: {@hospitalType}", hospitalType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateHospitalTypeCommand, Unit>> UpdateHospitalType(
            UpdateHospitalTypeCommand hospitalType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateHospitalTypeCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (hospitalType == null)
                    throw new ArgumentNullException(nameof(hospitalType), "HospitalType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospitalType);

                // Update postApiResult
                apiResult.Data = hospitalType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("HospitalType created successfully: {@hospitalType}", hospitalType);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospitalType != null)
                    logger.LogError(ex, "Error occurred while creating HospitalType: {@hospitalType}", hospitalType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHospitalTypeCommand, Unit>> DeleteHospitalType(
            DeleteHospitalTypeCommand hospitalType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHospitalTypeCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (hospitalType == null)
                    throw new ArgumentNullException(nameof(hospitalType), "HospitalType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospitalType);

                // Update postApiResult
                apiResult.Data = hospitalType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("HospitalType deleted successfully: {@hospitalType}", hospitalType);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospitalType != null)
                    logger.LogError(ex, "Error occurred while deleting HospitalType: {@hospitalType}", hospitalType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHospitalTypeByIdCommand, Unit>> DeleteHospitalType(
            DeleteHospitalTypeByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHospitalTypeByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "HospitalType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("HospitalType deleted successfully: {@hospitalType}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting HospitalType: {@hospitalType}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}