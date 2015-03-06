using System;
using ShadowrunLogic;
using NUnit.Framework;
namespace ShadowrunLogicTests
{
	[TestFixture]
	public class DiceTest
	{
		[Test]
		public void Roll ()
		{
			for (int i=0; i<100; i++) {
				int roll = Dice.Roll();
				Assert.LessOrEqual (roll, 6);
				Assert.GreaterOrEqual (roll, 1);
			}
		}
	}
}

