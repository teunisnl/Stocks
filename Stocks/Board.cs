using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Interfaces;

namespace Stocks
{
    public class Board
    {
        private LinkedListNode<ITile> tiles;

        public Board()
        {
            tiles = new LinkedListNode<ITile>(new Tile(0));
            var ltiles = new LinkedList<ITile>();
            ltiles.AddLast(tiles);
            for(var i =1; i < 40; i++) ltiles.AddLast(new Tile(i));
        }

        public ITile MovePlayer(IPlayer player, int number)
        {
            for (var i = 0; i < number; i++) tiles = tiles.NextOrFirst();
            return tiles.Value;
        }
    }

    internal static class CircularLinkedList
    {
        public static LinkedListNode<T> NextOrFirst<T>(this LinkedListNode<T> current)
        {
            return current.Next ?? current.List.First;
        }

        public static LinkedListNode<T> PreviousOrLast<T>(this LinkedListNode<T> current)
        {
            return current.Previous ?? current.List.Last;
        }
    }
}
