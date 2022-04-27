using System.ComponentModel.DataAnnotations;

namespace Secfi.Authentication.Application.Login;

public sealed class LoginUserCommand
{
	[StringLength(128, MinimumLength = 3)]
	public string Username { get; init; } = string.Empty;

	[StringLength(128, MinimumLength = 1)]
	public string Password { get; init; } = string.Empty;
}