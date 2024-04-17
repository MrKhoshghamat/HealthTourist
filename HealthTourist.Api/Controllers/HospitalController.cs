using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.Hospital.Commands.CreateHospital;
using HealthTourist.Application.Features.Main.Hospital.Commands.DeleteHospital;
using HealthTourist.Application.Features.Main.Hospital.Commands.UpdateHospital;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class HospitalController(IMediator mediator, IAppLogger<Hospital> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateHospitalCommand, int>> CreateHospital(
            CreateHospitalCommand hospital)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateHospitalCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (hospital == null)
                    throw new ArgumentNullException(nameof(hospital), "Hospital object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospital);

                // Update postApiResult
                apiResult.Data = hospital;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hospital created successfully: {@hospital}", hospital);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospital != null)
                    logger.LogError(ex, "Error occurred while creating Hospital: {@hospital}", hospital);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateHospitalCommand, Unit>> UpdateHospital(
            UpdateHospitalCommand hospital)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateHospitalCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (hospital == null)
                    throw new ArgumentNullException(nameof(hospital), "Hospital object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospital);

                // Update postApiResult
                apiResult.Data = hospital;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hospital update successfully: {@hospital}", hospital);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospital != null)
                    logger.LogError(ex, "Error occurred while updating Hospital: {@hospital}", hospital);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHospitalCommand, Unit>> DeleteHospital(
            DeleteHospitalCommand hospital)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHospitalCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (hospital == null)
                    throw new ArgumentNullException(nameof(hospital), "Hospital object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(hospital);

                // Update postApiResult
                apiResult.Data = hospital;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hospital deleted successfully: {@hospital}", hospital);
            }
            catch (Exception ex)
            {
                // Log error
                if (hospital != null)
                    logger.LogError(ex, "Error occurred while deleting Hospital: {@hospital}", hospital);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteHospitalByIdCommand, Unit>> DeleteHospital(
            DeleteHospitalByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteHospitalByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "Hospital object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Hospital deleted successfully: {@hospital}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting Hospital: {@hospital}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}