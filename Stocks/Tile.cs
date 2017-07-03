using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Interfaces;

namespace Stocks
{
    public class Tile : ITile
    {
        public int Index { get; }
        public Tile(int index)
        {
            this.Index = index;
        }
    }
}
