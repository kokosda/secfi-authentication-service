using System.Collections.Concurrent;

namespace Secfi.Authentication.Infrastructure.DataAccess;

public sealed class InMemoryDatabase : IInMemoryDatabase
{
	private readonly ConcurrentDictionary<string,object> _storage;

	public InMemoryDatabase()
	{
		_storage = new ConcurrentDictionary<string, object>();
	}

	public void PersistObject<T>(T @object, string key) where T: class
	{
		var combinedKey = GetCombinedKey<T>(key);

		if (!_storage.TryAdd(combinedKey, @object))
			throw new InvalidOperationException($"Cannot saved object with key {key} because it has already exists in the database.");
	}

	public T? GetPersistedObject<T>(string key) where T : class
	{
		var combinedKey = GetCombinedKey<T>(key);

		if (!_storage.TryGetValue(combinedKey, out var value))
			return null;

		var result = value as T;
		return result;
	}

	private static string GetCombinedKey<T>(string key) where T: class
	{
		var result = $"{typeof(T).FullName}_{key}" ?? throw new NullReferenceException($"Type's {typeof(T)} FullName is not defined.");
		return result;
	}
}