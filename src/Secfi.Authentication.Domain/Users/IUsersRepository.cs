namespace Secfi.Authentication.Domain.Users;

public interface IUsersRepository
{
	Task Save(User user);
	Task<User?> GetUserByUsername(string username);
}