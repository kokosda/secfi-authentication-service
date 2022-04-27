using Microsoft.AspNetCore.Mvc;
using Secfi.Authentication.Application.Login;
using Secfi.Authentication.Core.Handlers;

namespace Secfi.Authentication.Api.Controllers;

public sealed class LoginController : Controller
{
	private readonly IGenericCommandHandler<LoginUserCommand, LoginUserDto> _loginUserCommandHandler;

	public LoginController(IGenericCommandHandler<LoginUserCommand, LoginUserDto> loginUserCommandHandler)
	{
		_loginUserCommandHandler = loginUserCommandHandler;
	}

	[HttpPost]
	[Route("/")]
	public async Task<IActionResult> LoginUser([FromBody] LoginUserCommand loginUserCommand)
	{
		var createUserResponse = await _loginUserCommandHandler.HandleAsync(loginUserCommand);
		return StatusCode(createUserResponse.Value.HttpStatusCode, createUserResponse.Messages);
	}
}