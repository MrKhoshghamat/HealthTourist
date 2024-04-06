using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Interface;

namespace HealthTourist.Application.Features.Common.Attachment.Queries.GetAttachmentDetails;

public class GetAttachmentDetailsDto
{
    #region Properties

    public byte[] Content { get; set; }
    public string Name { get; set; }
    public FileExtensionEnum Extension { get; set; }

    #endregion

    #region Relations

    public virtual ICollection<HealthAttachment> HealthAttachments { get; set; }
    public virtual ICollection<HospitalAttachment> HospitalAttachments { get; set; }
    public virtual ICollection<HospitalGallery> HospitalGalleries { get; set; }
    public virtual ICollection<HotelAttachment> HotelAttachments { get; set; }
    public virtual ICollection<HotelGallery> HotelGalleries { get; set; }
    public virtual ICollection<OfficeAttachment> OfficeAttachments { get; set; }
    public virtual ICollection<SightseenAttachment> SightseenAttachments { get; set; }
    public virtual ICollection<TravelAttachment> TravelAttachments { get; set; }
    public virtual ICollection<TriageAttachment> TriageAttachments { get; set; }
    public virtual ICollection<FaqTypeAttachment> FaqTypeAttachments { get; set; }
    public virtual ICollection<TreatmentTypeAttachment> TreatmentTypeAttachments { get; set; }

    #endregion
}