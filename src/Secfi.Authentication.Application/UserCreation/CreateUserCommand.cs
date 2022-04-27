using System.ComponentModel.DataAnnotations;

namespace Secfi.Authentication.Application.UserCreation;

public sealed class CreateUserCommand
{
	[StringLength(128, MinimumLength = 3)]
	public string Username { get; init; } = string.Empty;

	[StringLength(128, MinimumLength = 1)]
	public string FirstName { get; init; } = string.Empty;

	[StringLength(128, MinimumLength = 1)]
	public string LastName { get; init; } = string.Empty;

	[StringLength(128, MinimumLength = 1)]
	public string Password { get; init; } = string.Empty;
}