using AutoMapper;
using HealthTourist.Application.Contracts.Interface;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Interface;
using MediatR;

namespace HealthTourist.Application.Features.Main.Hotel.Queries.GetHotelAttachmentsByHotelId;

public class GetHotelAttachmentsByHotelIdQueryHandler(
    IHotelAttachmentRepository hotelAttachmentRepository,
    IMapper mapper)
    : IRequestHandler<GetHotelAttachmentsByHotelIdQuery, GetHotelAttachmentsByHotelIdDto>
{
    public async Task<GetHotelAttachmentsByHotelIdDto> Handle(GetHotelAttachmentsByHotelIdQuery request,
        CancellationToken cancellationToken)
    {
        if (request == null) throw new BadRequestException("Incoming request is not valid");
        var hotelAttachment = await hotelAttachmentRepository.FindAsync(ha => ha.HotelId == request.HotelId);
        if (hotelAttachment == null) throw new NotFoundException(nameof(HotelAttachment), request.HotelId);

        var result = mapper.Map<GetHotelAttachmentsByHotelIdDto>(hotelAttachment);
        return result;
    }
}