namespace Secfi.Authentication.Domain.Users;

public interface IUsersManager
{
	Task<User> Create(CreateUserRequest createUserRequest);
}