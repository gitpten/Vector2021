using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VectorLib;

namespace VectorTest
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void TestSum()
        {
            Vector v1 = new Vector(2, 4);
            Vector v2 = new Vector(3, -2);
            Assert.AreEqual(v1 + v2, new Vector(5, 2));
        }

        [TestMethod]
        public void MirrorTest()
        {
            Assert.AreEqual(new Vector(3, -2).Mirror(new Vector(1, 0)), new Vector(3, 2));
            Assert.AreEqual(new Vector(-1, 3).Mirror(new Vector(0, 1)), new Vector(1, 3));
            Assert.AreEqual(new Vector(0, 3).Mirror(new Vector(1, 1)), new Vector(3, 0));
        }
    }
}
