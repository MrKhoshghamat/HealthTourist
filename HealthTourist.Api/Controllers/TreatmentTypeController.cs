using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.TreatmentType.Commands.CreateTreatmentType;
using HealthTourist.Application.Features.Main.TreatmentType.Commands.DeleteTreatmentType;
using HealthTourist.Application.Features.Main.TreatmentType.Commands.UpdateTreatmentType;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class TreatmentTypeController(IMediator mediator, IAppLogger<TreatmentType> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateTreatmentTypeCommand, int>> CreateTreatmentType(
            CreateTreatmentTypeCommand treatmentType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateTreatmentTypeCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (treatmentType == null)
                    throw new ArgumentNullException(nameof(treatmentType), "treatmentType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatmentType);

                // Update postApiResult
                apiResult.Data = treatmentType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("TreatmentType created successfully: {@TreatmentType}", treatmentType);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatmentType != null)
                    logger.LogError(ex, "Error occurred while creating TreatmentType: {@TreatmentType}", treatmentType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateTreatmentTypeCommand, Unit>> UpdateTreatmentType(
            UpdateTreatmentTypeCommand treatmentType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateTreatmentTypeCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (treatmentType == null)
                    throw new ArgumentNullException(nameof(treatmentType), "treatmentType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatmentType);

                // Update postApiResult
                apiResult.Data = treatmentType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("TreatmentType updated successfully: {@TreatmentType}", treatmentType);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatmentType != null)
                    logger.LogError(ex, "Error occurred while updating TreatmentType: {@TreatmentType}", treatmentType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTreatmentTypeCommand, Unit>> DeleteTreatmentType(
            DeleteTreatmentTypeCommand treatmentType)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTreatmentTypeCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (treatmentType == null)
                    throw new ArgumentNullException(nameof(treatmentType), "treatmentType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(treatmentType);

                // Update postApiResult
                apiResult.Data = treatmentType;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("TreatmentType deleted successfully: {@TreatmentType}", treatmentType);
            }
            catch (Exception ex)
            {
                // Log error
                if (treatmentType != null)
                    logger.LogError(ex, "Error occurred while deleting TreatmentType: {@TreatmentType}", treatmentType);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTreatmentTypeByIdCommand, Unit>> DeleteTreatmentType(
            DeleteTreatmentTypeByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTreatmentTypeByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "treatmentType object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("TreatmentType deleted successfully: {@TreatmentType}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting TreatmentType: {@TreatmentType}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}