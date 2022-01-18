using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lebewesen_Item.test
{
    [TestClass]
    public class lebewesen_Item_Tests
    {
        [TestMethod]
        public void lebewesen_Item_Hund_GibLaut_Test()
        {
            Lebewesen bello = new Hund(4, 40);
            Assert.AreEqual("Wau Wau", bello.GibLaut());
        }

        [TestMethod]
        public void lebewesen_Item_Katze_GibLaut_Test()
        {
            Lebewesen Minka = new Katze(4, 40);
            Assert.AreEqual("Mew", Minka.GibLaut());
        }

        [TestMethod]
        public void lebewesen_Item_Mensch_GibLaut_Test()
        {
            Lebewesen Martin = new Mensch(4, 40);
            Assert.AreEqual("Blablabla", Martin.GibLaut());
        }
    }
}
