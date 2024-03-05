using HealthTourist.Application.Features.AboutUsPage.Commands.CreateAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Commands.DeleteAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Commands.UpdateAboutUs;
using HealthTourist.Application.Features.AboutUsPage.Queries.GetAboutUsRecordDetails;
using HealthTourist.Application.Features.AboutUsPage.Queries.GetCurrentAboutUs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class AboutUsController(IMediator mediator) : BaseController
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        /// <exception cref="BadHttpRequestException"></exception>
        [HttpGet]
        public async Task<ActionResult<GetCurrentAboutUsDto>> Get()
        {
            var aboutUsRecords = await mediator.Send(new GetCurrentAboutUsQuery());
            return aboutUsRecords ?? throw new BadHttpRequestException("Not Found");
        }

        // GET api/<AboutUsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAboutUsRecordDetailsDto>> Get(int id)
        {
            var aboutUsRecordDetails = await mediator.Send(new GetAboutUsRecordDetailsQuery(id));
            return aboutUsRecordDetails;
        }

        // POST api/<AboutUsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreateAboutUsCommand aboutUs)
        {
            var response = await mediator.Send(aboutUs);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<AboutUsController>/5
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateAboutUsCommand aboutUs)
        {
            var response = await mediator.Send(aboutUs);
            return CreatedAtAction(nameof(Get), response);
        }

        // DELETE api/<AboutUsController>/5
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteAboutUsCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }
    }
}