using System;

namespace ShadowrunLogic
{
	public static class Dice
	{
		private static Random r;
		private static Random Random(){
			if(r == null)
				r = new Random();
			return r;
		}

		public static int Roll(){
			return Random().Next(1,7);
		}
	}
}

