namespace Secfi.Authentication.Application.UserCreation;

public sealed class CreateUserDto
{
	public string Id { get; init; } = string.Empty;
	public string Name { get; init; } = string.Empty;
	public string Gtin { get; init; } = string.Empty;
	public long TotalQuantity { get; init; }
}