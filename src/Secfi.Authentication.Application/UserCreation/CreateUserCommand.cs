using System.ComponentModel.DataAnnotations;

namespace Secfi.Authentication.Application.UserCreation;

public sealed class CreateUserCommand
{
	[StringLength(128, MinimumLength = 3)]
	public string Username { get; init; }

	[StringLength(128, MinimumLength = 1)]
	public string FirstName { get; init; }

	[StringLength(128, MinimumLength = 1)]
	public string LastName { get; init; }

	[StringLength(128, MinimumLength = 1)]
	public string Password { get; init; }
}