using System;
using System.Threading.Tasks;
using Secfi.Authentication.Application.Handlers;
using Secfi.Authentication.Core.Interfaces;
using Secfi.Authentication.Domain.Users;

namespace Secfi.Authentication.Application.UserCreation;

public sealed class CreateUserCommandHandler : GenericCommandHandlerBase<CreateUserCommand, CreateUserDto>
{
	private readonly IUsersRepository _usersRepository;

	public CreateUserCommandHandler(IUsersRepository usersRepository)
	{
		_usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(usersRepository));
	}

	protected override Task<IResponseContainerWithValue<CreateUserDto>> GetResultAsync(CreateUserCommand command)
	{
		throw new NotImplementedException();
	}
}