namespace Yamir.Data.Abstraction;

public abstract class AuditableEntity : Entity
{
    public DateTime UpdatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public Guid UpdatedBy { get; set; }

    public bool IsDeleted { get; set; }
}