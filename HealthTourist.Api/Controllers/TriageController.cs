using HealthTourist.Application.Features.Triage.Commands.CreatePatient;
using HealthTourist.Application.Features.Triage.Commands.DeletePatient;
using HealthTourist.Application.Features.Triage.Commands.UpdatePatient;
using HealthTourist.Application.Features.Triage.Queries.GetPatientDetails;
using HealthTourist.Application.Features.Triage.Queries.GetPatients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class TriageController(IMediator mediator) : BaseController
    {
        /// <summary>
        /// Get Patients List
        /// </summary>
        /// <returns></returns>
        /// <exception cref="BadHttpRequestException"></exception>
        [HttpGet]
        public async Task<ActionResult<List<GetPatientsDto>>> Get()
        {
            var patients = await mediator.Send(new GetPatientsQuery());
            return patients ?? throw new BadHttpRequestException("Not Found");
        }

        /// <summary>
        /// Get Patient Detail by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPatientDetailsDto>> Get(long id)
        {
            var patient = await mediator.Send(new GetPatientDetailsQuery(id));
            return patient;
        }

        /// <summary>
        /// Post Patient Information through Triage form
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreatePatientCommand patient)
        {
            var response = await mediator.Send(patient);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        /// <summary>
        /// Put or Edit Patient Information through Triage form
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdatePatientCommand patient)
        {
            var response = await mediator.Send(patient);
            return CreatedAtAction(nameof(Get), response);
        }

        /// <summary>
        /// Delete Patient Information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(long id)
        {
            var response = await mediator.Send(new DeletePatientCommand() { Id = id });
            return CreatedAtAction(nameof(Get), response);
        }
    }
}