using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLib;

namespace ShapeLibTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Radius lower then zero")]
        public void TestCircleRadius()
        {
            Circle a = new Circle(-5);
        }

        [TestMethod]
        public void TestCircleZero()
        {
            Circle a = new Circle(0);
            Assert.AreEqual(0, a.GetSquare());
        }

        [TestMethod]
        public void TestCircle1()
        {
            Circle a = new Circle(1);
            Assert.AreEqual(Math.PI, a.GetSquare());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
        "Side/Sides lower/equal then zero")]
        public void TestTriangleZero()
        {
            Triangle a = new Triangle(-1, 1, 1);
        }

        [TestMethod]
        public void TestNormalValues()
        {
            Triangle a = new Triangle(3, 4, 5);
            Assert.AreEqual(6, a.GetSquare());
        }
        [TestMethod]
        public void TestNormalValues1()
        {
            Triangle a = new Triangle(1, 1, 1);
            Assert.AreEqual(0.4330127018922193, a.GetSquare());
        }
    }
}