namespace VsaArchitecture.Application.Contracts.Persistent;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
