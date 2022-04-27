using Secfi.Authentication.Core.Interfaces;

namespace Secfi.Authentication.Core.ResponseContainers
{
	public sealed class ResponseContainerWithValue<T> : ResponseContainer, IResponseContainerWithValue<T> where T: new()
	{
		public T Value { get; private set; } = new();

		public void SetSuccessValue(T value)
		{
			Value = value;
			IsSuccess = true;
		}

		public void SetErrorValue(T value, string message)
		{
			Value = value;
			AddErrorMessage(message);
		}

		public new IResponseContainerWithValue<T> JoinWith(IResponseContainer anotherResponseContainer)
		{
			base.JoinWith(anotherResponseContainer);
			return this;
		}
	}
}
