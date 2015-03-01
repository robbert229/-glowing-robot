using System;

namespace ShadowrunLogic
{
	public class Pool
	{
		public int Dice { get; set; }
		public int Limit {get; set; }

		public Pool (int Dice)
		{
			this.Dice = Dice;
			this.Limit = 0;
		}

		public Pool (int Dice, int Limit)
		{
			this.Dice = Dice;
			this.Limit = Limit;
		}
	}
}

