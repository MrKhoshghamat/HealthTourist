namespace HealthTourist.Domain.Persistence;

public abstract class BaseEntity<TPrimaryKey>
{
    public TPrimaryKey Id { get; set; }
    public string CreatorId { get; set; }
    public DateTime CreationDateTime { get; set; }
    public string ModifierId { get; set; }
    public DateTime ModificationDateTime { get; set; }
    public string RemoverId { get; set; }
    public DateTime DeletionDateTime { get; set; }
    public bool IsDeleted { get; set; }
}