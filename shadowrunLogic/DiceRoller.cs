using System;

namespace ShadowrunLogic
{
	public class DiceRoller
	{
		Random random;
		public DiceRoller ()
		{
			random = new Random();
		}

		public int Roll (Pool pool, int modifiers)
		{
			int result = random.Next(pool.Dice - modifiers);
			if(result > pool.Limit)
				result = pool.Limit;

			return result;
		}

		public int Roll (Pool pool)
		{
			return Roll (pool,0);
		}
	}
}

