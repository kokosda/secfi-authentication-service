using System;
using System.Net;
using System.Threading.Tasks;
using Secfi.Authentication.Application.Handlers;
using Secfi.Authentication.Core.Interfaces;
using Secfi.Authentication.Core.ResponseContainers;
using Secfi.Authentication.Domain.Users;

namespace Secfi.Authentication.Application.UserCreation;

public sealed class CreateUserCommandHandler : GenericCommandHandlerBase<CreateUserCommand, CreateUserDto>
{
	private readonly IUsersManager _usersManager;

	public CreateUserCommandHandler(IUsersManager usersManager)
	{
		_usersManager = usersManager;
	}

	protected override async Task<IResponseContainerWithValue<CreateUserDto>> GetResultAsync(CreateUserCommand command)
	{
		var result = new ResponseContainerWithValue<CreateUserDto>();
		var createUserRequest = new CreateUserRequest
		{
			Username = command.Username,
			FirstName = command.FirstName,
			LastName = command.LastName,
			Password = command.Password
		};

		CreateUserDto createUserDto;

		try
		{
			await _usersManager.Create(createUserRequest);
			createUserDto = new CreateUserDto { HttpStatusCode = (int)HttpStatusCode.Created };
			result.SetSuccessValue(createUserDto);
		}
		catch (Exception ex)
		{
			createUserDto = new CreateUserDto { HttpStatusCode = (int)HttpStatusCode.BadRequest };
			result.SetErrorValue(createUserDto, ex.Message);
		}

		return result;
	}
}