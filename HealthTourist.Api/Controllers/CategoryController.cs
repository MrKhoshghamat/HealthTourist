using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Main.Category.Commands.CreateCategory;
using HealthTourist.Application.Features.Main.Category.Commands.DeleteCategory;
using HealthTourist.Application.Features.Main.Category.Commands.UpdateCategory;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Main;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class CategoryController(IMediator mediator, IAppLogger<Category> logger) : BaseController
    {
        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreateCategoryCommand, int>> CreateCategory(
            CreateCategoryCommand category)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreateCategoryCommand, int>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (category == null)
                    throw new ArgumentNullException(nameof(category), "Category object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(category);

                // Update postApiResult
                apiResult.Data = category;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Category created successfully: {@category}", category);
            }
            catch (Exception ex)
            {
                // Log error
                if (category != null)
                    logger.LogError(ex, "Error occurred while creating category: {@category}", category);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdateCategoryCommand, Unit>> UpdateCategory(
            UpdateCategoryCommand category)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdateCategoryCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (category == null)
                    throw new ArgumentNullException(nameof(category), "Category object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(category);

                // Update postApiResult
                apiResult.Data = category;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Category updated successfully: {@category}", category);
            }
            catch (Exception ex)
            {
                // Log error
                if (category != null)
                    logger.LogError(ex, "Error occurred while updating category: {@category}", category);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeleteCategoryCommand, Unit>> DeleteCategory(
            DeleteCategoryCommand category)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteCategoryCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (category == null)
                    throw new ArgumentNullException(nameof(category), "Category object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(category);

                // Update postApiResult
                apiResult.Data = category;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Category deleted successfully: {@category}", category);
            }
            catch (Exception ex)
            {
                // Log error
                if (category != null)
                    logger.LogError(ex, "Error occurred while deleting category: {@category}", category);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeleteCategoryByIdCommand, Unit>> DeleteCategory(
            DeleteCategoryByIdCommand id)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, DeleteCategoryByIdCommand, Unit>
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
                logger.LogInformation("Category deleted successfully: {@category}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null)
                    logger.LogError(ex, "Error occurred while deleting category: {@category}", id);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
    }
}