namespace VsaArchitecture.Application.Entities;

public class UserLoginHistory
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required DateTime LoginAttemtedOn { get; set; }
    public required bool LoginStatus { get; set; }
    public string? IPAddress { get; set; }
    public string? UserAgent { get; set; }
    public DateTime? LoggedOutOn { get; set; }
}
