namespace Secfi.Authentication.Domain.Users;

public sealed class User
{
	public string Username { get; init; } = string.Empty;
	public string FirstName { get; init; } = string.Empty;
	public string LastName { get; init; } = string.Empty;
	public string PasswordHash { get; init; } = string.Empty;
	public string PasswordSalt { get; init; } = string.Empty;
}