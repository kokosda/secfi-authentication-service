using Secfi.Authentication.Domain.Users;

namespace Secfi.Authentication.Infrastructure.DataAccess.Users;

public sealed class UsersRepository : IUsersRepository
{
	private readonly IInMemoryDatabase _inMemoryDatabase;

	public UsersRepository(IInMemoryDatabase inMemoryDatabase)
	{
		_inMemoryDatabase = inMemoryDatabase ?? throw new ArgumentNullException(nameof(inMemoryDatabase));
	}

	public Task Save(User user)
	{
		_inMemoryDatabase.PersistObject(user, user.Username);
		return Task.FromResult(user);
	}

	public Task<User?> GetUserByUsername(string username)
	{
		var result = _inMemoryDatabase.GetPersistedObject<User>(username);
		return Task.FromResult(result);
	}
}