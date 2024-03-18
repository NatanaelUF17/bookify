using Bookify.Domain.Users;

namespace Bookify.Domain.Abstractions.Interfaces.Repository;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(User user);
}