using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestTrollGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDamageOfPlayer()
        {

            Player player = new Player(50);
            player.receiveDamage(10);

            Assert.AreEqual(40, player.currentHitPoints);

        }


    }
}
