using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp12;

namespace UnitTestProject1
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.aaa(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}

