using Secfi.Authentication.Core.Domain;

namespace Secfi.Authentication.Core.Interfaces
{
	public interface ISpecification<in T, TId> where T : EntityBase<TId> where TId: new()
	{
		IResponseContainer IsSatisfiedBy(T entity);
	}
}