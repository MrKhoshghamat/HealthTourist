using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.Treatment.Commands.CreateTreatment;
using HealthTourist.Application.Features.Main.Treatment.Commands.DeleteTreatment;
using HealthTourist.Application.Features.Main.Treatment.Commands.UpdateTreatment;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class TreatmentController(IMediator mediator, IAppLogger<Treatment> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateTreatmentCommand, int>> CreateTreatment(
            CreateTreatmentCommand treatment)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateTreatmentCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (treatment == null)
                    throw new ArgumentNullException(nameof(treatment), "treatment object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatment);

                // Update postApiResult
                apiResult.Data = treatment;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("treatment created successfully: {@treatment}", treatment);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatment != null)
                    logger.LogError(ex, "Error occurred while creating treatment: {@treatment}", treatment);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateTreatmentCommand, Unit>> UpdateTreatment(
            UpdateTreatmentCommand treatment)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateTreatmentCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (treatment == null)
                    throw new ArgumentNullException(nameof(treatment), "treatment object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatment);

                // Update postApiResult
                apiResult.Data = treatment;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("treatment updated successfully: {@treatment}", treatment);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatment != null)
                    logger.LogError(ex, "Error occurred while updating treatment: {@treatment}", treatment);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTreatmentCommand, Unit>> DeleteTreatment(
            DeleteTreatmentCommand treatment)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTreatmentCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (treatment == null)
                    throw new ArgumentNullException(nameof(treatment), "treatment object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatment);

                // Update postApiResult
                apiResult.Data = treatment;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("treatment deleted successfully: {@treatment}", treatment);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatment != null)
                    logger.LogError(ex, "Error occurred while deleting treatment: {@treatment}", treatment);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTreatmentByIdCommand, Unit>> DeleteTreatment(
            DeleteTreatmentByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTreatmentByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "treatment object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("treatment deleted successfully: {@treatment}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting treatment: {@treatment}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}