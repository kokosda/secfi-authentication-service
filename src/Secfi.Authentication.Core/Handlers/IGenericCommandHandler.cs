using System.Threading.Tasks;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Core.Handlers
{
	public interface IGenericCommandHandler<in TCommand, TResult>
	{
		Task<IResponseContainerWithValue<TResult>> HandleAsync(TCommand command);
	}
}
