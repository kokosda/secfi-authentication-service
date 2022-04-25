using Microsoft.Extensions.DependencyInjection;
using Secfi.Authentication.Application.UserCreation;
using Secfi.Authentication.Core.Handlers;

namespace Secfi.Authentication.Application.DependencyInjection
{
	public static class DependencyRegistrar
	{
		public static IServiceCollection AddApplicationLevelServices(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddSingleton<IGenericCommandHandler<CreateUserCommand, CreateUserDto>, CreateUserCommandHandler>();
			return serviceCollection;
		}
	}
}
