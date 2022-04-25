using System;
using System.Threading.Tasks;
using Secfi.Authentication.Core.Handlers;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Application.Handlers
{
	public abstract class QueryHandlerBase<T> : IQueryHandler<T>
	{
		public async Task<IResponseContainer> HandleAsync(T query)
		{
			if (query == null)
				throw new ArgumentNullException(nameof(query));

			var result = await GetResultAsync(query);
			return result;
		}

		protected abstract Task<IResponseContainer> GetResultAsync(T command);
	}
}
