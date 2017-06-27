using System;
namespace Stocks
{
	public interface IDice
	{
		int minValue { get; }
		int maxValue { get; }

		int Roll();
	}
}
