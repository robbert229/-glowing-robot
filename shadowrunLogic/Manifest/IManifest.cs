using System;
using System.Collections.Generic;

namespace ShadowrunLogic
{
	public interface IManifest<E>
	{
		List<E> GetContents();
		string PackName();
	}
}

