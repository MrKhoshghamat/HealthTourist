using System.Net;
using HealthTourist.Api.Models.Results;
using HealthTourist.Application.Contracts.Logging;
using HealthTourist.Application.Features.Account.Person.Commands.CreatePerson;
using HealthTourist.Application.Features.Account.Person.Commands.DeletePerson;
using HealthTourist.Application.Features.Account.Person.Commands.UpdatePerson;
using HealthTourist.Application.Features.Account.Person.Queries.GetPersons;
using HealthTourist.Common.Enumerations.API;
using HealthTourist.Domain.Account;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class AccountController(IMediator mediator, IAppLogger<Person> logger) : BaseController
    {
        [HttpGet]
        public async Task<List<GetPersonsDto>> GetPersons()
        {
            var getPersonsDto = new List<GetPersonsDto>();

            var persons =
                await mediator.Send(new GetPersonsQuery());

            foreach (var person in persons)
            {
                foreach (var personsDto in getPersonsDto)
                {
                    personsDto.FirstName = person.FirstName;
                    personsDto.LastName = person.LastName;
                    personsDto.BirthDate = person.BirthDate;
                    personsDto.Gender = person.Gender;
                    personsDto.PhoneNumber = person.PhoneNumber;
                    personsDto.Email = person.Email;
                    personsDto.Address = person.Address;
                    personsDto.IsPatient = person.IsPatient;
                    personsDto.IsGuest = person.IsGuest;
                    personsDto.IsDoctor = person.IsDoctor;
                    personsDto.IsAdmin = person.IsAdmin;
                }
            }

            return getPersonsDto;
        }

        [HttpPost]
        public async Task<ApiResult<ApiMethodsEnum, CreatePersonCommand, long>> CreatePerson(CreatePersonCommand person)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, CreatePersonCommand, long>
            {
                Method = ApiMethodsEnum.Post
            };

            try
            {
                // Validate input parameters
                if (person == null) throw new ArgumentNullException(nameof(person), "Person object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(person);

                // Update postApiResult
                apiResult.Data = person;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Person created successfully: {@Person}", person);
            }
            catch (Exception ex)
            {
                // Log error
                if (person != null) logger.LogError(ex, "Error occurred while creating person: {@Person}", person);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpPut]
        public async Task<ApiResult<ApiMethodsEnum, UpdatePersonCommand, Unit>> UpdatePerson(UpdatePersonCommand person)
        {
            var apiResult = new ApiResult<ApiMethodsEnum, UpdatePersonCommand, Unit>
            {
                Method = ApiMethodsEnum.Put
            };

            try
            {
                // Validate input parameters
                if (person == null) throw new ArgumentNullException(nameof(person), "Person object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(person);

                // Update postApiResult
                apiResult.Data = person;
                apiResult.Response = response;
                apiResult.IsSucceed = true;
                apiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Person updated successfully: {@Person}", person);
            }
            catch (Exception ex)
            {
                // Log error
                if (person != null) logger.LogError(ex, "Error occurred while updating person: {@Person}", person);

                // Set error details in postApiResult
                apiResult.IsSucceed = false;
                apiResult.ErrorMessage = ex.Message;
                apiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return apiResult;
        }
        
        [HttpDelete]
        public async Task<ApiResult<ApiMethodsEnum, DeletePersonCommand, Unit>> DeletePerson(DeletePersonCommand person)
        {
            var postApiResult = new ApiResult<ApiMethodsEnum, DeletePersonCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (person == null) throw new ArgumentNullException(nameof(person), "Person object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(person);

                // Update postApiResult
                postApiResult.Data = person;
                postApiResult.Response = response;
                postApiResult.IsSucceed = true;
                postApiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Person deleted successfully: {@Person}", person);
            }
            catch (Exception ex)
            {
                // Log error
                if (person != null) logger.LogError(ex, "Error occurred while deleting person: {@Person}", person);

                // Set error details in postApiResult
                postApiResult.IsSucceed = false;
                postApiResult.ErrorMessage = ex.Message;
                postApiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return postApiResult;
        }
        
        [HttpDelete("{id}")]
        public async Task<ApiResult<ApiMethodsEnum, DeletePersonByIdCommand, Unit>> DeletePerson(DeletePersonByIdCommand id)
        {
            var postApiResult = new ApiResult<ApiMethodsEnum, DeletePersonByIdCommand, Unit>
            {
                Method = ApiMethodsEnum.Delete
            };

            try
            {
                // Validate input parameters
                if (id == null) throw new ArgumentNullException(nameof(id), "Person object cannot be null.");

                // Send command to mediator
                var response = await mediator.Send(id);

                // Update postApiResult
                postApiResult.Data = id;
                postApiResult.Response = response;
                postApiResult.IsSucceed = true;
                postApiResult.HttpResponse = HttpStatusCode.OK;

                // Log success
                logger.LogInformation("Person deleted successfully: {@Person}", id);
            }
            catch (Exception ex)
            {
                // Log error
                if (id != null) logger.LogError(ex, "Error occurred while deleting person: {@Person}", id);

                // Set error details in postApiResult
                postApiResult.IsSucceed = false;
                postApiResult.ErrorMessage = ex.Message;
                postApiResult.HttpResponse = HttpStatusCode.InternalServerError;
            }

            return postApiResult;
        }
    }
}