using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        [TestMethod()]
        public void FootballPlayerTest()
        {
            FootballPlayer player = new FootballPlayer("Mads", 1700, 6);
            FootballPlayer player2 = new FootballPlayer("Mads", 1700, 6);
            Assert.AreEqual("Mads", player.Name);
            Assert.AreEqual(1700, player.Price);
            Assert.AreEqual(6, player.ShirtNumber);
            Assert.AreEqual(1, player.Id);
            Assert.AreEqual(2, player2.Id);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => player.Name = "iii");

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => player.Price = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => player.ShirtNumber = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => player.ShirtNumber = 101);
        }
    }
}