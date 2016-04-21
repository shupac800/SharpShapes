using System;
using SharpShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleTest()
        {
            double radius = 1;
            Assert.AreEqual(Circle.pi, Circle.area(radius));
            Assert.AreEqual(Circle.pi * 2 * radius, Circle.circumference(radius));
        }

        [TestMethod]
        public void SquareTest()
        {
            Assert.AreEqual(9, Square.area(3));
            Assert.AreEqual(12, Square.perimeter(3));
        }

        [TestMethod]
        public void RhombusTest()
        {
            Assert.AreEqual(16, Rhombus.area(4));
            Assert.AreEqual(20, Rhombus.perimeter(5));
        }

        [TestMethod]
        public void CylinderTest()
        {
            Assert.AreEqual(Cylinder.pi * 1 * 1 * 3, Cylinder.volume(1, 3));
            Assert.AreEqual( (2 * Cylinder.pi * 1 * 3) + 2 * Cylinder.pi * 1 * 1, Cylinder.area(1, 3) );
        }

        [TestMethod]
        public void CubeTest()
        {
            Assert.AreEqual(24, Cube.area(2));
            Assert.AreEqual(8, Cube.volume(2));
        }

        [TestMethod]
        public void SphereTest()
        {
            double radius = 6.6017;
            Assert.AreEqual((4 / 3) * Sphere.pi * Math.Pow(radius, 3), Sphere.volume(radius));
            Assert.AreEqual(4 * Sphere.pi * Math.Pow(radius, 2), Sphere.area(radius));
        }
    }
}
