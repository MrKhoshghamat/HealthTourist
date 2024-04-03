namespace HealthTourist.Domain.Main;

public class Treatment : BaseEntity<int>
{
    #region Properties

    public int TreatmentTypeId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }

    #endregion

    #region Relations

    public virtual TreatmentType TreatmentType { get; set; }
    public virtual ICollection<Doctor> Doctors { get; set; }
    public virtual ICollection<TeamMember> TeamMembers { get; set; }
    public virtual ICollection<Triage> Triages { get; set; }

    #endregion
}