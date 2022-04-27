using Microsoft.AspNetCore.Mvc;
using Secfi.Authentication.Application.UserCreation;
using Secfi.Authentication.Core.Handlers;

namespace Secfi.Authentication.Api.Controllers;

public sealed class UsersController : Controller
{
	private readonly IGenericCommandHandler<CreateUserCommand, CreateUserDto> _createUserCommandHandler;

	public UsersController(IGenericCommandHandler<CreateUserCommand, CreateUserDto> createUserCommandHandler)
	{
		_createUserCommandHandler = createUserCommandHandler;
	}

	[HttpPost]
	[Route("/")]
	public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand createUserCommand)
	{
		var createUserResponse = await _createUserCommandHandler.HandleAsync(createUserCommand);
		return StatusCode(createUserResponse.Value.HttpStatusCode, createUserResponse.Messages);
	}
}