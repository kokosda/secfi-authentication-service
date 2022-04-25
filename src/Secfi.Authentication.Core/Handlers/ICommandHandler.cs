using System.Threading.Tasks;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Core.Handlers
{
	public interface ICommandHandler<in T>
	{
		Task<IResponseContainer> HandleAsync(T command);
	}
}
