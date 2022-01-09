using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1;


namespace tp1.Test
{
    [TestClass] //Annotation
    public class TestClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            tp1.TestClass ersterTest = new tp1.TestClass(); 
            Assert.AreEqual(1, ersterTest.getWert1());
        }

        [TestMethod]
        public void TestMethod2()
        {
            tp1.TestClass ersterTest = new tp1.TestClass(2);
            Assert.AreEqual(2, ersterTest.getWert1());
        }
    }
}
