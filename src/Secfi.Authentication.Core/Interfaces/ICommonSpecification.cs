﻿using System.Threading.Tasks;

namespace Secfi.Authentication.Core.Interfaces
{
	public interface ICommonSpecification<in T>
	{
		Task<IResponseContainer> IsSatisfiedBy(T subject);
	}
}
