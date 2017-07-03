using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stocks;

namespace StocksTests
{
    [TestFixture()]
    public class BoardTests
    {
        [Test()]
        public void TestPlayerMovement()
        {
            var b = new Board();
            var t = b.MovePlayer(null, 3);
            Assert.AreEqual(3, t.Index);
        }
    }
}
