using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.Tag.Commands.CreateTag;
using HealthTourist.Application.Features.Main.Tag.Commands.DeleteTag;
using HealthTourist.Application.Features.Main.Tag.Commands.UpdateTag;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class TagController(IMediator mediator, IAppLogger<Tag> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateTagCommand, int>> CreateTag(CreateTagCommand tag)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateTagCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (tag == null)
                    throw new ArgumentNullException(nameof(tag), "Tag object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(tag);

                // Update postApiResult
                apiResult.Data = tag;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Tag created successfully: {@tag}", tag);
            }
            catch (Exception ex)
            {
                // Log error
                if (tag != null)
                    logger.LogError(ex, "Error occurred while creating tag: {@tag}", tag);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateTagCommand, Unit>> UpdateTag(UpdateTagCommand tag)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateTagCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (tag == null)
                    throw new ArgumentNullException(nameof(tag), "Tag object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(tag);

                // Update postApiResult
                apiResult.Data = tag;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Tag updated successfully: {@tag}", tag);
            }
            catch (Exception ex)
            {
                // Log error
                if (tag != null)
                    logger.LogError(ex, "Error occurred while updating tag: {@tag}", tag);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTagCommand, Unit>> DeleteTag(DeleteTagCommand tag)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTagCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (tag == null)
                    throw new ArgumentNullException(nameof(tag), "Tag object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(tag);

                // Update postApiResult
                apiResult.Data = tag;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Tag deleted successfully: {@tag}", tag);
            }
            catch (Exception ex)
            {
                // Log error
                if (tag != null)
                    logger.LogError(ex, "Error occurred while deleting tag: {@tag}", tag);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteTagByIdCommand, Unit>> DeleteTag(DeleteTagByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteTagByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null)
                    throw new ArgumentNullException(nameof(id), "Tag object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                apiResult.Data = id;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Tag created successfully: {@tag}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while creating tag: {@tag}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}