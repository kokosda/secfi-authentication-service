using Secfi.Authentication.Core.Domain;

namespace Secfi.Authentication.Domain.Users;

public sealed record CreateUserRequest : ValueObject
{
	public string? Username { get; init; }
	public string? FirstName { get; init; }
	public string? LastName { get; init; }
	public string? Password { get; init; }
}