using System;	

namespace Stocks
{
	public class Dice : IDice
	{
		private Random rnd;
		public int minValue { get; }
		public int maxValue { get; }

		private Dice() { rnd = new Random(); }

		private Dice(int seed) { rnd = new Random(seed); }

		public Dice(int minValue, int maxValue) : this()
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
		}

		public Dice(int minValue, int maxValue, int seed) : this(seed)
		{
			this.minValue = minValue;
			this.maxValue = maxValue;
		}

		public int Roll()
		{
			return rnd.Next(this.minValue, this.maxValue);
		}
	}
}
