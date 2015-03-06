using System;

namespace ShadowrunLogic
{
	public static class Initiative
	{
		static Random r;
		private static Random getRandom(){
			if(r == null)
				r = new Random();
			return r;
		}

		public static int Roll(AbstractAttributes attributes){
			int dice = attributes.InitiativeDice();
			int mod = attributes.InitiativeModifier();

			int result = mod;
			for(int i=0;i<dice;i++)
				result += Dice.Roll();

			Console.Write ("Rolled {0}",result);
			return result;
		}
	}
}

