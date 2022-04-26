namespace Secfi.Authentication.Domain.Cryptography;

public interface IPasswordHashProvider
{
	PasswordHash GetPasswordHash(string password);
}