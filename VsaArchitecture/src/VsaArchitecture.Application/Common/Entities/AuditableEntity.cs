namespace VsaArchitecture.Application.Common.Entities;

public abstract class AuditableEntity
{
    public required DateTime CreatedOn { get; set; }
    public required string CreatedBy { get; set; } = null!;
    public DateTime? LastModifiedOn { get; set; }
    public string? LastModifiedBy { get; set; }
}
