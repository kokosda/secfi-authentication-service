using Secfi.Authentication.Domain.Cryptography;

namespace Secfi.Authentication.Domain.Users;

public sealed class UsersManager : IUsersManager
{
	private readonly IPasswordHashProvider _passwordHashProvider;
	private readonly IUsersRepository _usersRepository;

	public UsersManager(IPasswordHashProvider passwordHashProvider, IUsersRepository usersRepository)
	{
		_passwordHashProvider = passwordHashProvider;
		_usersRepository = usersRepository;
	}

	public async Task<User> Create(CreateUserRequest createUserRequest)
	{
		if (string.IsNullOrWhiteSpace(createUserRequest.Username))
			throw new InvalidOperationException("Username cannot be empty.");

		var existingUser = await _usersRepository.GetUserByUsername(createUserRequest.Username);

		if (existingUser is not null)
			throw new InvalidOperationException($"User {createUserRequest.Username} already exists.");

		if (string.IsNullOrWhiteSpace(createUserRequest.Password))
			throw new InvalidOperationException("Password cannot be empty.");

		var passwordHash = _passwordHashProvider.GetPasswordHash(createUserRequest.Password);

		if (string.IsNullOrWhiteSpace(createUserRequest.FirstName))
			throw new InvalidOperationException("FirstName cannot be empty.");

		if (string.IsNullOrWhiteSpace(createUserRequest.LastName))
			throw new InvalidOperationException("LastName cannot be empty.");

		var result = new User
		{
			Username = createUserRequest.Username,
			FirstName = createUserRequest.FirstName,
			LastName = createUserRequest.LastName,
			PasswordHash = passwordHash.Hash,
			PasswordSalt = passwordHash.Salt
		};

		await _usersRepository.Save(result);

		return result;
	}
}