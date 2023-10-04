using VsaArchitecture.Application.Common;

namespace VsaArchitecture.Application.Entities;

public class User: AuditableEntity
{
    public required Guid Id { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }

    public string? Email { get; set; }
    public string? Phone { get; set; }
}
