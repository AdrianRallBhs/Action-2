using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convert;

namespace ConversionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestF2C()
        {
            double f = 32;
            double c = 0;
            double rvalue = Convert.Convert.f2c(f);
            Assert.AreEqual(c, rvalue);
            Assert.AreEqual(100, Convert.Convert.f2c(212));
        }

        [TestMethod]
        public void TestC2F()
        {
            Assert.AreEqual(212, Convert.Convert.c2f(100));
            Assert.AreEqual(32, Convert.Convert.c2f(0));
        }
    }
}