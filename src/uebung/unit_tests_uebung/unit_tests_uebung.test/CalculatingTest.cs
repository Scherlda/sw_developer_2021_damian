using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace unit_tests_uebung.test
{
    [TestClass]
    public class CalculatingTest
    {
        [TestMethod]
        public void AddierenTestNoOptionalParameter()
        {
            Calculating addtest1 = new Calculating();
            Assert.AreEqual(5, addtest1.Addieren(2, 3));
        }

        [TestMethod]
        public void AddierenTestWithOptionalParameter()
        {
            Calculating addtest1 = new Calculating();
            Assert.AreEqual(10, addtest1.Addieren(2, 3, wert3: 5));
        }

    }
}
