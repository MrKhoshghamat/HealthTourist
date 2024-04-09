using HealthTourist.Common.Enumerations.Common;
using HealthTourist.Domain.Main;

namespace HealthTourist.Domain.Interface;

public class DoctorSocialMedia
{
    #region Properties

    public long DoctorId { get; set; }
    public SocialMediaEnum SocialMedia { get; set; }
    public string Link { get; set; }

    #endregion

    #region Relations

    public virtual Doctor Doctor { get; set; }

    #endregion
}