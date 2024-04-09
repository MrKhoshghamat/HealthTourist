using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.TreatmentType.Queries.GetTreatmentTypeIconByTreatmentTypeId;

public class GetTreatmentTypeIconByTreatmentTypeIdQueryHandler(
    ITreatmentTypeAttachmentRepository treatmentTypeAttachmentRepository)
    : IRequestHandler<GetTreatmentTypeIconByTreatmentTypeIdQuery, GetTreatmentTypeIconByTreatmentTypeIdDto>
{
    public async Task<GetTreatmentTypeIconByTreatmentTypeIdDto> Handle(
        GetTreatmentTypeIconByTreatmentTypeIdQuery request, CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var treatmentAttachment =
            await treatmentTypeAttachmentRepository.FindAsync(tta => tta.TreatmentTypeId == request.TreatmentTypeId);
        if (treatmentAttachment == null)
            throw new NotFoundException(nameof(TreatmentTypeAttachment), request.TreatmentTypeId);

        var result = new GetTreatmentTypeIconByTreatmentTypeIdDto()
        {
            TreatmentTypeId = treatmentAttachment.TreatmentTypeId,
            AttachmentId = treatmentAttachment.Attachment.Id,
            Content = treatmentAttachment.Attachment.Content
        };

        return result;
    }
}