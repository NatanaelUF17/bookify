namespace Bookify.Domain.Abstractions.Interfaces.Repository;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}