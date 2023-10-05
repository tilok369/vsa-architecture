namespace VsaArchitecture.Application.Contracts.Authentication;

public interface ICurrentUserService
{
    string? UserId { get; }
}
