using Secfi.Authentication.Domain.Cryptography;

namespace Secfi.Authentication.Infrastructure.DataAccess.Cryptography;

public sealed class BCryptPasswordHashProvider : IPasswordHashProvider
{
	public PasswordHash GetPasswordHash(string password)
	{
		var result = new PasswordHash
		{
			Hash = BCrypt.Net.BCrypt.HashPassword(password),
			Salt = BCrypt.Net.BCrypt.GenerateSalt()
		};

		return result;
	}
}