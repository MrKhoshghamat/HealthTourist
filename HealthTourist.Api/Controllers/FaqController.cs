using HealthTourist.Api.Models.Faq.Main;
using HealthTourist.Api.Models.Faq.Sub;
using HealthTourist.Application.Features.Main.Faq.Queries.GetFaqsByFaqTypeId;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeIconByFaqTypeId;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypes;
using HealthTourist.Application.Features.Main.FaqType.Queries.GetFaqTypeSelectedIconByFaqTypeId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HealthTourist.Api.Controllers
{
    [ApiController]
    public class FaqController(IMediator mediator) : BaseController
    {
        [HttpGet]
        public async Task<GetFaqDto> GetFaq(int faqTypeId)
        {
            var getFaqDto = new GetFaqDto();

            var faqTypes = await mediator.Send(new GetFaqTypesQuery());
            var faqsByFaqTypeId = await mediator.Send(new GetFaqsByFaqTypeIdQuery(faqTypeId));

            foreach (var faqType in faqTypes)
            {
                var faqTypeIcon = await mediator.Send(new GetFaqTypeIconByFaqTypeIdQuery(faqType.Id));
                var selectedFaqTypeIcon =
                    await mediator.Send(new GetFaqTypeSelectedIconByFaqTypeIdQuery(faqType.Id, true));

                getFaqDto.FaqTypes =
                [
                    new FaqFaqTypesDto()
                    {
                        Name = faqType.Name,
                        Title = faqType.Title,
                        Description = faqType.Description,
                        Icon = File(faqTypeIcon.Content, "img/jpeg"),
                        SelectedIcon = File(selectedFaqTypeIcon.Content, "img/jpeg")
                    }
                ];
            }

            foreach (var faq in faqsByFaqTypeId)
            {
                getFaqDto.Faq = new FaqFaqDto()
                {
                    Name = faq.Name,
                    Title = faq.Title,
                    Description = faq.Description,
                    FaqTypeId = faq.FaqTypeId,
                    IsFirstPage = faq.IsFirstPage,
                    Priority = faq.Priority
                };
            }

            return getFaqDto;
        }
    }
}