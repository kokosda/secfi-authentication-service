using System;
using System.Threading.Tasks;
using Secfi.Authentication.Core.Handlers;
using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Application.Handlers
{
	public abstract class GenericCommandHandlerBase<TCommand, TResult> : IGenericCommandHandler<TCommand, TResult>
	{
		public async Task<IResponseContainerWithValue<TResult>> HandleAsync(TCommand command)
		{
			if (command == null)
				throw new ArgumentNullException(nameof(command));

			return await GetResultAsync(command);
		}

		protected abstract Task<IResponseContainerWithValue<TResult>> GetResultAsync(TCommand command);
	}
}
