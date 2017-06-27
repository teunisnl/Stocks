using NUnit.Framework;
using System;
using Stocks;

namespace StocksTests
{
	[TestFixture()]
	public class DiceTests
	{
		[Test()]
		public void TestDice()
		{
			var dice = new Dice(1, 6, 1);
			Assert.AreEqual(2, dice.Roll());
			Assert.AreEqual(1, dice.Roll());
			Assert.AreEqual(3, dice.Roll());
		}
	}
}
