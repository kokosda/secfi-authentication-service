using System.Threading.Tasks;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Core.Handlers
{
	public interface IGenericQueryHandler<in TQuery, TResult>
	{
		Task<IResponseContainerWithValue<TResult>> HandleAsync(TQuery query);
	}
}
