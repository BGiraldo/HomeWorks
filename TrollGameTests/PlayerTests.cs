using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrollGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrollGame.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void receiveDamageTest()
        {
           
                Player player = new Player(50);
                player.receiveDamage(10);

                Assert.AreEqual(40, player.currentHitPoints);

        }

    }
}