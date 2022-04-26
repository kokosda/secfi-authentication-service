using Secfi.Authentication.Core.Domain;

namespace Secfi.Authentication.Domain.Cryptography;

public sealed record PasswordHash : ValueObject
{
	public string Hash { get; set; } = string.Empty;
	public string Salt { get; set; } = string.Empty;
}