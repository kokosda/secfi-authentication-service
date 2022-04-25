using Secfi.Authentication.Domain.Users;

namespace Secfi.Authentication.Infrastructure.DataAccess.Products;

public sealed class UsersRepository : IUsersRepository
{
	private readonly IInMemoryDatabase _inMemoryDatabase;

	public UsersRepository(IInMemoryDatabase inMemoryDatabase)
	{
		_inMemoryDatabase = inMemoryDatabase ?? throw new ArgumentNullException(nameof(inMemoryDatabase));
	}
}