using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Secfi.Authentication.Domain.Cryptography;
using Secfi.Authentication.Domain.Users;
using Secfi.Authentication.Infrastructure.DataAccess;
using Secfi.Authentication.Infrastructure.DataAccess.Cryptography;
using Secfi.Authentication.Infrastructure.DataAccess.Users;

namespace Secfi.Authentication.Infrastructure.DependencyInjection
{
	public static class DependencyRegistrar
	{
		public static IServiceCollection AddInfrastructureLevelServices(this IServiceCollection serviceCollection, IConfiguration configuration)
		{
			serviceCollection.AddSingleton<IInMemoryDatabase, InMemoryDatabase>();
			serviceCollection.AddSingleton<IUsersRepository, UsersRepository>();
			serviceCollection.AddSingleton<IPasswordHashProvider, BCryptPasswordHashProvider>();
			serviceCollection.AddSingleton<IUsersManager, UsersManager>();

			return serviceCollection;
		}
	}
}
