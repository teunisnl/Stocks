using System;
using System.Collections.Generic;

namespace Stocks
{
	public class Game
	{
		List<IDice> dices = new List<IDice>();
		List<IPlayer> players = new List<IPlayer>();
		List<ICard> cards = new List<ICard>();
		List<IStockChange> stockchanges = new List<IStockChange>();
		IBank bank;

		public Game()
		{
			InitDices();
		}

		#region Inits
		private void InitDices()
		{
			dices.Add(new Dice(1, 6));	
			dices.Add(new Dice(1, 6));
		}
		#endregion Inits
	}
}
