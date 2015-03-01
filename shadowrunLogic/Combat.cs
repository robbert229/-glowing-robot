using System;

namespace ShadowrunLogic
{
	public class Combat
	{
		Pool attackPool;
		Pool dodgePoo;

		AbstractAttributes attacker;
		AbstractAttributes defender;

		public Combat ()
		{

		}


		public int Resolve ()
		{
			return -1;
		}
	}
}

