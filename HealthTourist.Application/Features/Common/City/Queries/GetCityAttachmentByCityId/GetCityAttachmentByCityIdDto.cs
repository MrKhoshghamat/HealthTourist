namespace HealthTourist.Application.Features.Common.City.Queries.GetCityAttachmentByCityId;

public class GetCityAttachmentByCityIdDto
{
    public int CityId { get; set; }
    public Guid AttachmentId { get; set; }
    public string CityName { get; set; }
    public byte[] Content { get; set; }
}