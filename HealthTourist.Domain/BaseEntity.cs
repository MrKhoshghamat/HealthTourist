namespace HealthTourist.Domain;

public abstract class BaseEntity<TPrimaryKey>
{
    public TPrimaryKey Id { get; set; }
    public string CreatorId { get; set; }
    public DateTime CreationDateTime { get; set; } = DateTime.Now;
    public string? ModifierId { get; set; }
    public DateTime ModificationDateTime { get; set; } = DateTime.MinValue;
    public string? RemoverId { get; set; }
    public DateTime DeletionDateTime { get; set; } = DateTime.MinValue;
    public bool IsDeleted { get; set; } = false;
    public bool IsDisabled { get; set; } = false;
}
