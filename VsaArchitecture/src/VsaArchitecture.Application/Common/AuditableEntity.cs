namespace VsaArchitecture.Application.Common;

public abstract class AuditableEntity
{
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime? LastModifiedOn { get; set; }
    public string? LastModifiedBy { get; set; }
}
