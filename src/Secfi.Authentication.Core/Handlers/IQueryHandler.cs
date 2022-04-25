using System.Threading.Tasks;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Core.Handlers
{
    public interface IQueryHandler<in T>
    {
        Task<IResponseContainer> HandleAsync(T query);
    }
}