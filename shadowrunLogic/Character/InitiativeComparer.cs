using System;
using ShadowrunLogic;
using System.Collections.Generic;
using System.Collections;

namespace ShadowrunLogic
{
	public class InitiativeComparer : IComparer<Character>
	{
		public int Compare(Character x, Character y)
		{
			return y.initiative - x.initiative;
		}		
	}

}

