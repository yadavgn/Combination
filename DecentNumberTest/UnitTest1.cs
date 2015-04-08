using System;
using FindDecentNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecentNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var T = new NumberFinder(3, 5);
            Assert.AreEqual(T.GetDecentNumber(2), "-1");
            Assert.AreEqual(T.GetDecentNumber(4), "-1");
            Assert.AreEqual(T.GetDecentNumber(3), "333");
        }
    }
}
